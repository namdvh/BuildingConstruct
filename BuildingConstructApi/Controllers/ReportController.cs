using Application.System.Notifies;
using Application.System.Reports;
using BuildingConstructApi.Hubs;
using Data.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ViewModels.MaterialStore;
using ViewModels.Pagination;

namespace BuildingConstructApi.Controllers
{
    [Route("api/report")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        private readonly IHubContext<NotificationUserHub> _notificationUserHubContext;
        private readonly IUserConnectionManager _userConnectionManager;
        private readonly BuildingConstructDbContext _context;

        public ReportController(IReportService reportService, IHubContext<NotificationUserHub> notificationUserHubContext, IUserConnectionManager userConnectionManager, BuildingConstructDbContext context)
        {
            _reportService = reportService;
            _notificationUserHubContext = notificationUserHubContext;
            _userConnectionManager = userConnectionManager;
            _context = context;
        }


        [HttpPost("getAll")]
        public async Task<IActionResult> GetAllReport([FromBody] PaginationFilter request,int? storeID)
        {
            var validFilter = new PaginationFilter();

            if (request.FilterRequest == null)
            {
                validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            }
            else
            {
                validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy, request.FilterRequest);

            }

            var result = await _reportService.GetAllReportProduct(request,storeID);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateReport([FromBody] ReportRequestDTO request)
        {
            var rs = await _reportService.ReportProduct(request);
            return Ok(rs);
        }

    }
}
