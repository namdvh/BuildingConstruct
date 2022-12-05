using Application.ClaimTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Response;
using ViewModels.Users;

namespace Application.Users
{
    public interface IUserService
    {
        public Task<BaseResponse<UserModels>> Login(LoginRequestDTO request);
        Task<RegisterResponseDTO> Register(RegisterRequestDTO request);
        public Task<Token> GenerateToken(UserModels request);
    }
}
