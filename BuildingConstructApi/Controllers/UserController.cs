using Application.ClaimTokens;
using Application.Users;
using Data.Entities;
using Data.Enum;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Security.Claims;
using System.Text;
using ViewModels.Response;
using ViewModels.Users;

namespace BuildingConstructApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        public UserController(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var rs = await _userService.Login(request);
            if (rs.Data == null)
            {
                return Ok(new
                {
                    code = BaseCode.ERROR,
                    Message = "Username or Password is Incorrect"
                });
            }
            else
            {
                var token = await _userService.GenerateToken(rs.Data);
                if (token != null)
                {
                    try
                    {
                        var userPrincipalac = this.ValidateToken(token.Data.AccessToken);
                        var authProperties = new AuthenticationProperties
                        {
                            ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60),
                            IsPersistent = true,
                            AllowRefresh = true,
                        };
                        await HttpContext.SignInAsync(userPrincipalac, authProperties);
                    }
                    catch (Exception)
                    {
                    }
                    token.Message = "Login Success";
                    token.Code = BaseCode.SUCCESS;

                }
                return Ok(token);

            }
        }
        [HttpPost("refresh")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenResponse refreshToken)
        {
            var rs = await _userService.RefreshToken(refreshToken);

            return Ok(rs);
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
        [HttpPost("generate")]
        public async Task<IActionResult> GenerateToken([FromBody] UserModels request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var rs = _userService.GenerateToken(request);
            return Ok(rs);
        }

        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _configuration["Tokens:Issuer"];
            validationParameters.ValidIssuer = _configuration["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            ClaimsPrincipal principal;
            principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            RegisterResponseDTO rs = await _userService.Register(request);
            return Ok(rs);
        }
    }
}
