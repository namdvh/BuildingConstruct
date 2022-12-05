using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Users;

namespace Application.ClaimTokens
{
    public class Token
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

        public UserModels User { get; set; }
        public string? Code { get; set; }
        public string? Message { get; set; }
        public Token(string code, string msg)
        {
            Code = code;
            Message = msg;
        }
        public Token(string accessToken, string refreshToken, UserModels user, string code, string message, DateTime refreshTokenExpiryTime)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            User = user;
            Code = code;
            Message = message;
            RefreshTokenExpiryTime = refreshTokenExpiryTime;
        }

        public Token()
        {

        }
    }

}
