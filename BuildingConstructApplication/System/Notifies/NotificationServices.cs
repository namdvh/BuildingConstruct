using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Pagination;
using ViewModels.Response;
using ViewModels.Notificate;

namespace Application.System.Notifies
{
    public class NotificationServices : INotificationServices
    {
        private readonly BuildingConstructDbContext _context;
        private IHttpContextAccessor _accessor;

        public NotificationServices(BuildingConstructDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public async Task<BasePagination<List<NotificationDTO>>> GetAllNotification(PaginationFilter filter, Guid UserId)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value.ToString();
            BasePagination<List<NotificationDTO>> response = new();
            var orderBy = filter._orderBy.ToString();
            int totalRecord;

            if (string.IsNullOrEmpty(filter._sortBy))
            {
                filter._sortBy = "Id";
            }
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            IQueryable<Notification> query = (IQueryable<Notification>)_context.Notifcations.Include(x => x.User);


            var data = await query
                .AsNoTracking()
               .OrderBy(filter._sortBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();
            //var rs = await .Where(x => x.UserID.ToString().Equals(userID)).ToListAsync();
            if (data == null)
            {

                response.Code = BaseCode.ERROR;
                response.Message = "Cannot find!!!";
                return response;
            }
            else
            {
                response.Code = BaseCode.SUCCESS;
                response.Message = BaseCode.SUCCESS_MESSAGE;
                response.Data = await MapListDTO(data);
            }

            return response;
        }
        public async Task<List<NotificationDTO>> MapListDTO(List<Notification> list)
        {
            List<NotificationDTO> result = new();

            foreach (var item in list)
            {
                NotificationDTO dto = new();
                dto.Id = item.Id;
                dto.UserID = item.UserID;
                dto.Title = item.Title;
                dto.Type = item.Type;
                dto.Message = item.Message;
                dto.IsRead = item.IsRead;
                dto.CreateBy = item.CreateBy;
                dto.LastModifiedAt = item.LastModifiedAt;
                var user = await _context.Users.FindAsync(item.CreateBy);
                if (user != null)
                {
                    dto.Author = new();
                    dto.Author.FirstName = user.FirstName;
                    dto.Author.LastName = user.LastName;
                    dto.Author.Avatar = user.Avatar;
                }
               
                result.Add(dto);
            }
            return result;
        }
    }
}
