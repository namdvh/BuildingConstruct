using Application.ClaimTokens;
using Application.Users;
using Data.DataContext;
using Data.Entities;
using Data.Enum;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ViewModels.Response;
using ViewModels.Users;

namespace Application.Systems.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userService;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        private readonly BuildingConstructDbContext _context;
        private readonly string emailApi = "";
        public UserService(UserManager<User> userService, SignInManager<User> signInManager, RoleManager<Role> roleManager, IConfiguration config, BuildingConstructDbContext context)
        {
            _userService = userService;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _context = context;
        }
        public async Task<BaseResponse<UserModels>> Login(LoginRequestDTO request)
        {
            BaseResponse<UserModels> response = new();
            if (request.UserName != null)
            {
                var user = await _userService.FindByNameAsync(request.UserName);
                var rs = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);

                if (user == null)
                {
                    response.Code = "202";
                    response.Message = "Invalid Username or password";
                    return response;
                }
                if (!rs.Succeeded)
                {
                    var linq = _context.Users.Where(x => x.PhoneNumber == request.PhoneNumber);
                    var us = (User)linq;

                    if (linq.Any())
                    {
                        rs = await _signInManager.PasswordSignInAsync(us, request.Password, request.RememberMe, true);
                        if (rs.Succeeded)
                        {
                            response.Code = "200";
                            response.Message = "Login Success";
                            var roleName = (from usr in _context.Users
                                            join userRole in _context.UserRoles on user.Id equals userRole.UserId
                                            join role in _context.Roles on userRole.RoleId equals role.Id
                                            select role.Name).FirstOrDefault();
                            if (roleName == null)
                            {
                                response.Code = "202";
                                response.Message = "Role Name is null";
                                return response;
                            }

                            var roles = await _userService.GetRolesAsync(user);
                            var userDTO = MapToDto(us, roleName);
                            var token = await GenerateToken(userDTO);
                            user.Token = token.RefreshToken;
                            user.RefreshTokenExpiryTime = (DateTime)token.RefreshTokenExpiryTime;
                            await _userService.UpdateAsync(user);
                            response.Data = userDTO;
                        }
                        else
                        {
                            response.Code = "202";
                            response.Message = "Invalid Username or password";
                        }
                    }
                    else
                    {
                        response.Code = "202";
                        response.Message = "Invalid Username or password";
                    }
                }
                else
                {
                    response.Code = "200";
                    response.Message = "Login Success";
                    var roleName = (from usr in _context.Users
                                    join userRole in _context.UserRoles on user.Id equals userRole.UserId
                                    join role in _context.Roles on userRole.RoleId equals role.Id
                                    select role.Name).FirstOrDefault();
                    if (roleName == null)
                    {
                        response.Code = "202";
                        response.Message = "Role Name is null";
                        return response;
                    }

                    var roles = await _userService.GetRolesAsync(user);
                    var userDTO = MapToDto(user, roleName);
                    var token = await GenerateToken(userDTO);
                    user.Token = token.RefreshToken;
                    user.RefreshTokenExpiryTime = (DateTime)token.RefreshTokenExpiryTime;
                    await _userService.UpdateAsync(user);
                    response.Data = userDTO;
                }
            }
            return response;

        }
        private UserModels MapToDto(User user, string roleName)
        {
            var userDto = new UserModels()
            {
                Id = user.Id,
                UserName = user.UserName,
                Phone=user.PhoneNumber
            };
            return userDto;
        }

        public async Task<RegisterResponseDTO> Register(RegisterRequestDTO request)
        {
            RegisterResponseDTO response = new RegisterResponseDTO();
            RegisterRequestValidatorDTO validator = new();
            ValidationResult results = validator.Validate(request);

            var defaultRole = _roleManager.FindByIdAsync(request.RoleID).Result;

            if (!results.IsValid)
            {

                response.Data = null;
                response.Code = "202";
                foreach (var failure in results.Errors)
                {
                    response.Messages = failure.ErrorMessage.ToString();
                }
                return response;
            }
            else
            {
                var user = new User()
                {
                    UserName = request.UserName,
                    PhoneNumber = request.Phone,
                    Status = Data.Enum.Status.Level1
                };

                var rs = await _userService.CreateAsync(user, request.Password);
                if (rs.Succeeded)
                {

                    await _userService.AddToRoleAsync(user, defaultRole.Name);

                    if (defaultRole.Id == Guid.Parse(BaseCode.UsRole))
                    {
                        var builder = new Builder();
                        builder.CreateBy = user.Id;
                        await _context.Builders.AddAsync(builder);
                        await _context.SaveChangesAsync();
                    }
                    else if (defaultRole.Id == Guid.Parse(BaseCode.StoreRole))
                    {
                        var store = new MaterialStore();
                        store.CreateBy = user.Id;
                        await _context.MaterialStores.AddAsync(store);
                        await _context.SaveChangesAsync();
                    }
                    else if (defaultRole.Id == Guid.Parse(BaseCode.ContractorRole))
                    {
                        var ctor = new Contractor();
                        ctor.CreateBy = user.Id;
                        await _context.Contractors.AddAsync(ctor);
                        await _context.SaveChangesAsync();
                    }
                    response.Data = user;
                    response.Code = "200";
                    response.Messages = "Regist successfully";
                    return response;
                }
                response.Code = "202";
                response.Messages = "Username already exists ";

                return response;
            }
        }

        public async Task<Token> GenerateToken(UserModels request)
        {
            var response = new Token();
            var claims = new[]
            {

                new Claim(ClaimTypes.Name,request.UserName),
                new Claim(ClaimTypes.Role,string.Join(";",request.Role))
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var accesstoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);
            var refreshtoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: creds);
            var ReturnToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
            var ReturnRFToken = new JwtSecurityTokenHandler().WriteToken(refreshtoken);
            //save rf token to db
            response.AccessToken = ReturnToken;
            response.RefreshToken = ReturnRFToken;
            response.RefreshTokenExpiryTime = refreshtoken.ValidTo;
            response.Code = "200";
            response.Message = "generate token success";
            return response;
        }
    }
}
