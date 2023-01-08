using Application.ClaimTokens;
using Data.DataContext;
using Data.Entities;
using Data.Enum;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Dynamic.Core;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using ViewModels.Response;
using ViewModels.Users;

namespace Application.System.Users
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

        public async Task<BaseResponse<UserModels>> UpdateRole(UpdateRoleRequest request)
        {
            BaseResponse<UserModels> response = new();
            var users = await _userService.FindByIdAsync(request.UserId);
            var roleNames = await _context.Roles.Where(x => x.Id.ToString().Equals(request.RoleId)).Select(x => x.Name).SingleOrDefaultAsync();
                
                if (request.RoleId == BaseCode.UsRole)
                {
                    var builder = new Builder();
                    builder.CreateBy = users.Id;
                    await _context.Builders.AddAsync(builder);
                    _context.SaveChanges();

                    users.BuilderId = builder.Id;
                    _context.Entry<User>(users).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                    else if (request.RoleId == BaseCode.StoreRole)
                {
                    var store = new MaterialStore();
                    store.CreateBy = users.Id;

                    await _context.MaterialStores.AddAsync(store);
                    _context.SaveChanges();

                    users.MaterialStoreID = store.Id;
                    _context.Entry(store).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                else if (request.RoleId == BaseCode.ContractorRole)
                {
                    var ctor = new Contractor();
                    ctor.CreateBy = users.Id;

                    await _context.Contractors.AddAsync(ctor);
                    _context.SaveChanges();
                    users.ContractorId = ctor.Id;
                    _context.Entry(ctor).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                
                    await _userService.AddToRoleAsync(users, roleNames);
                
                    var roleName = (from usr in _context.Users
                                join userRole in _context.UserRoles on users.Id equals userRole.UserId
                                join role in _context.Roles on userRole.RoleId equals role.Id
                                select role.Name).FirstOrDefault();
            UserModels u = new()
            {
                Id = users.Id
            };
                var userDTO = MapToDto(users, roleName);
                var token = await GenerateToken(userDTO);
                users.Token = token.Data.RefreshToken;
                users.RefreshTokenExpiryTime = (DateTime)token.Data.RefreshTokenExpiryTime;
                await _userService.UpdateAsync(users);
                response.Data = u;
                response.Data = userDTO;
                    
            return response;
        }

        public async Task<BaseResponse<UserModels>> LoginGoogle(LoginGoogleRequest request)
        {
            BaseResponse<UserModels> response = new();
            
            var users = await _userService.FindByNameAsync(request.Email);// check email exist or not
            
            if (users == null) 
            {
                var user = new User()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    UserName = request.Email,
                    Avatar = request.Avatar,
                    Provider = Provider.GOOGLE,
                    Status = Status.Level1
                };
                var rs = await _userService.CreateAsync(user, request.Email);

                UserModels us = new()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Avatar = user.Avatar,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                };
                
                    response.Data = us;
                    response.Code = "201";
                    response.Message = "Regist successfully but haven't got role";
                    return response;
            }
            else
            {
                var roleName = (from usr in _context.Users
                                join userRole in _context.UserRoles on users.Id equals userRole.UserId
                                join role in _context.Roles on userRole.RoleId equals role.Id
                                select role.Name).FirstOrDefault();  //get roleName from db
                if (roleName == null)
                {
                    UserModels us = new()
                    {
                        UserName = users.UserName,
                        Avatar = users.Avatar,
                        FirstName = users.FirstName,
                        LastName = users.LastName,
                    };
                    response.Data = us; 
                    response.Code = "202";
                    response.Message = "Role Name is null";
                    return response;
                }
                UserModels u = new()
                {
                    Id = users.Id,
                    UserName = users.UserName,
                    Avatar = users.Avatar,
                    FirstName = users.FirstName,
                    LastName = users.LastName,
                    Role = roleName
                };
                var userDTO = MapToDto(users, roleName);
                var token = await GenerateToken(userDTO);
                users.Token = token.Data.RefreshToken;
                users.RefreshTokenExpiryTime = (DateTime)token.Data.RefreshTokenExpiryTime;
                await _userService.UpdateAsync(users);

                response.Data = userDTO;
                response.Data = u;
                response.Code = "200";
                response.Message = "Login Success";
            }
            return response;
        }


        public async Task<BaseResponse<UserModels>> Login(LoginRequestDTO request)
        {
            BaseResponse<UserModels> response = new();
            dynamic rs;
            //var user = await _userService.FindByNameAsync(request.UserName);
            rs = await _signInManager.PasswordSignInAsync(request.UserName, request.Password, request.RememberMe, true);// hàm login

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
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    UserName = request.Phone,
                    PhoneNumber = request.Phone,
                    Status = Status.Level1
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
                        _context.SaveChanges();

                        user.BuilderId = builder.Id;
                        _context.Entry<User>(user).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                    }
                    else if (defaultRole.Id == Guid.Parse(BaseCode.StoreRole))
                    {
                        var store = new MaterialStore();
                        store.CreateBy = user.Id;
                        
                        await _context.MaterialStores.AddAsync(store);
                        _context.SaveChanges();

                        user.MaterialStoreID =store.Id;
                        _context.Entry(store).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                    }
                    else if (defaultRole.Id == Guid.Parse(BaseCode.ContractorRole))
                    {
                        var ctor = new Contractor();
                        ctor.CreateBy = user.Id;
                      
                        await _context.Contractors.AddAsync(ctor);
                        _context.SaveChanges();
                        user.ContractorId = ctor.Id;
                        _context.Entry(ctor).State = EntityState.Modified;
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
                new Claim(ClaimTypes.Name,request.Phone!=null?request.Phone:request.UserName),
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
