using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.NotificationModels;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.Notifies
{
    public interface INotificationServices
    {
        Task<BasePagination<List<NotificationDTO>>> GetAllNotification(PaginationFilter filter,Guid UserId);
    }
}
