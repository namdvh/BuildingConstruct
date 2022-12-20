using Application.ClaimTokens;
using Application.Users;
using Data.DataContext;
using Data.Entities;
using Data.Enum;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
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
            dynamic rs;
            //var user = await _userService.FindByNameAsync(request.UserName);
            rs = await _signInManager.PasswordSignInAsync(request.UserName, request.Password, request.RememberMe, true);

            if (!rs.Succeeded)
            {
                var us = _context.Users.FirstOrDefault(x => x.PhoneNumber == request.PhoneNumber);

                if (us == null)
                {
                    return response;
                }
                else
                {
                    rs = await _signInManager.PasswordSignInAsync(us, request.Password, request.RememberMe, true);
                    if (rs.Succeeded)
                    {

                        var roleName = (from usr in _context.Users
                                        join userRole in _context.UserRoles on us.Id equals userRole.UserId
                                        join role in _context.Roles on userRole.RoleId equals role.Id
                                        select role.Name).FirstOrDefault();
                        if (roleName == null)
                        {
                            response.Code = "202";
                            response.Message = "Role Name is null";
                            return response;
                        }

                        var roles = await _userService.GetRolesAsync(us);
                        var userDTO = MapToDto(us, roleName);
                        var token = await GenerateToken(userDTO);
                        us.Token = token.Data.RefreshToken;
                        us.RefreshTokenExpiryTime = (DateTime)token.Data.RefreshTokenExpiryTime;
                        await _userService.UpdateAsync(us);
                        response.Data = userDTO;
                    }
                }
                return response;

            }
            else
            {
                var user = await _userService.FindByNameAsync(request.UserName);
                if (user == null)
                {

                    return response;
                }
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
                user.Token = token.Data.RefreshToken;
                user.RefreshTokenExpiryTime = (DateTime)token.Data.RefreshTokenExpiryTime;
                await _userService.UpdateAsync(user);
                response.Data = userDTO;
            }


            return response;

        }
        private UserModels MapToDto(User user, string roleName)
        {
            var userDto = new UserModels()
            {
                Id = user.Id,
                UserName = user.UserName,
                Phone = user.PhoneNumber
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
                    UserName = "",
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

        public async Task<BaseResponse<Token>> GenerateToken(UserModels request)
        {
            var response = new BaseResponse<Token>();
            var token = new Token();
            var claims = new[]
            {
                new Claim("UserID",request.Id.ToString()),
                new Claim(ClaimTypes.MobilePhone,request.Phone),
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
            token.AccessToken = ReturnToken;
            token.RefreshToken = ReturnRFToken;
            token.RefreshTokenExpiryTime = refreshtoken.ValidTo;
            response.Data = token;
            response.Code = "200";
            response.Message = "generate token success";
            return response;
        }

        public async Task<BaseResponse<string>> RefreshToken(RefreshTokenResponse refreshToken)
        {
            BaseResponse<string> response = new();
            var tokenHandler = new JwtSecurityTokenHandler();



            dynamic principal = null;
            try
            {
                principal = GetPrincipalFromToken(refreshToken.RefreshToken);
                if (GetPrincipalFromToken(refreshToken.RefreshToken) == null)
                {
                    response.Code = "900";
                    response.Message = "Invalid Token";
                    return response;
                }
            }
            catch (SecurityTokenExpiredException)
            {

                response.Code = "901";
                response.Message = "Expired Token";
                return response;
            }
            catch (SecurityTokenInvalidSignatureException)
            {
                response.Code = "900";
                response.Message = "Invalid Token";
                return response;
            }
            catch (ArgumentException)
            {
                response.Code = "900";
                response.Message = "Arugment invalid Token";
                return response;
            }


            string username = principal.Identity.Name;
            var user = await _userService.FindByNameAsync(username);

            if (user == null || user.Token != refreshToken.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                response.Code = "901";
                response.Message = "Expired Token";
                return response;
            }
            var roles = await _userService.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Role,string.Join(";",roles))
                };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var accesstoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: creds);
            TokenResponse token = new();
            var newAccessToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
            token.AccessToken = newAccessToken;
            response.Data = token.AccessToken;
            response.Code = "200";
            response.Message = "Generate new token successfully";
            return response;
        }
        private ClaimsPrincipal GetPrincipalFromToken(string? token)

        {
            var principal = (dynamic)null;
            try
            {
                string issuer = _config.GetValue<string>("Tokens:Issuer");
                string signingKey = _config.GetValue<string>("Tokens:Key");
                byte[] signingKeyBytes = Encoding.UTF8.GetBytes(signingKey);

                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateAudience = true,
                    ValidAudience = issuer,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes),
                };
                principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            }
            catch (SecurityTokenExpiredException ex)
            {
                throw new SecurityTokenExpiredException();
            }
            catch (SecurityTokenInvalidSignatureException e)
            {
                throw new SecurityTokenInvalidSignatureException();
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException();
            }
            return principal;
        }
    }
}
