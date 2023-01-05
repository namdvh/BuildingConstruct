using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Pagination;
using ViewModels.Response;
using ViewModels.SavePost;

namespace Application.System.SavePost
{
    public class SaveService : ISaveService
    {
        private readonly BuildingConstructDbContext _context;
        private IHttpContextAccessor _accessor;

        public SaveService(BuildingConstructDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public async Task<BaseResponse<string>> SavePost(SavePostRequest request)
        {
            BasePagination<string> response = new();
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            if (identifierClaim == null)
            {
                response.Message = BaseCode.ERROR_MESSAGE;
                response.Code = "202";
                return response;
            }
            var userID = identifierClaim.Value;
            Save save = new()
            {
                Date = DateTime.Now,
                BuilderPostId = request.BuiderPostId,
                ContractorPostId = request.ContractorPostId,
                UserId = Guid.Parse(userID)
            };
                await _context.Saves.AddAsync(save);
                var rs = await _context.SaveChangesAsync();
            if (rs > 0)
            {
                response.Message = BaseCode.SUCCESS_MESSAGE;
                response.Code = "200";
            }
            else
            {
                response.Message = BaseCode.ERROR_MESSAGE;
                response.Code = "202";
            }
            return response;
        }
    }
}
