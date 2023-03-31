using Application.System.Notifies;
using Application.System.Reports;
using BuildingConstructApi.Hubs;
using Data.DataContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ViewModels.MaterialStore;
using ViewModels.Pagination;

namespace BuildingConstructApi.Controllers
{
    [Route("api/report")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
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
        public async Task<IActionResult> GetAllReport([FromBody] PaginationFilter request)
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

            var result = await _reportService.GetAllReportProduct(request);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateReport([FromBody] ReportRequestDTO request)
        {
            var rs = await _reportService.ReportProduct(request);
            return Ok(rs);
        }
        [HttpPost("createReportPost")]
        public async Task<IActionResult> CreatePostReport([FromBody] ReportRequestDTO request)
        {
            var rs = await _reportService.ReportPost(request);
            return Ok(rs);
        }
        [HttpPost("getAllPostReport")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPostReport([FromBody] PaginationFilter request)
        {
            var validFilter = new PaginationFilter();
            var id = User.FindFirst("UserID").Value;

            if (request.FilterRequest == null)
            {
                validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            }
            else
            {
                validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy, request.FilterRequest);

            }

            var result = await _reportService.GetAllReportPost(request);
            return Ok(result);
        }

    }
}
