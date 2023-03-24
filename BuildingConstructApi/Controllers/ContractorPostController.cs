using Application.System.ContractorPosts;
using Application.System.Notifies;
using BuildingConstructApi.Hubs;
using Data.DataContext;
using Data.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using ViewModels.ContractorPost;
using ViewModels.Notificate;
using ViewModels.Pagination;
using ViewModels.Response;

namespace BuildingConstructApi.Controllers
{
    [Route("api/contractorpost")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class ContractorPostController : ControllerBase
    {
        private readonly IContractorPostService _contractorPostService;
        private readonly IHubContext<NotificationUserHub> _notificationUserHubContext;
        private readonly IUserConnectionManager _userConnectionManager;
        private readonly BuildingConstructDbContext _context;

        public ContractorPostController(IContractorPostService contractorPostService, BuildingConstructDbContext context, IUserConnectionManager userConnectionManager, IHubContext<NotificationUserHub> notificationUserHubContext)
        {
            _contractorPostService = contractorPostService;
            _context = context;
            _userConnectionManager = userConnectionManager;
            _notificationUserHubContext = notificationUserHubContext;
        }

        [HttpPost("getAll")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll([FromBody] PaginationFilter request)
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



            var result = await _contractorPostService.GetPost(request, Guid.Parse(id));
            return Ok(result);
        }


        [HttpPost("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPostByUserID([FromBody] PaginationFilter filter, [FromRoute] Guid id)
        {
            var validFilter = new PaginationFilter();

            if (filter.FilterRequest == null)
            {
                validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._sortBy, filter._orderBy);
            }
            else
            {
                validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter._sortBy, filter._orderBy, filter.FilterRequest);

            }



            var result = await _contractorPostService.GetPost(filter, id);
            return Ok(result);
        }



        [HttpPost("contractor/getAll")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPostContractor([FromBody] PaginationFilter request)
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



            var result = await _contractorPostService.GetPostByContractor(request, Guid.Parse(id));
            return Ok(result);
        }




        [HttpPost("applied")]
        public async Task<IActionResult> AppliedPost([FromBody] AppliedPostRequest request)
        {
            string? rs = User.FindFirst("UserID")?.Value;
            var result = await _contractorPostService.AppliedPost(request, Guid.Parse(rs));

            if (result.Data.Equals("ALREADY_APPLIED"))
            {
                return Ok(result);
            }

            NotificationModels noti = new();
            noti.NotificationType = NotificationType.TYPE_1;
            noti.Message = NotificationMessage.APPLIEDNOTI;
            noti.CreateBy = Guid.Parse(rs.ToString());
            noti.UserId = Guid.Parse(result.Data.ToString());
            var author = await _context.Users.Where(x => x.Id.ToString().Equals(noti.CreateBy.ToString())).FirstOrDefaultAsync();
            noti.Author = new();
            noti.Author.FirstName = author.FirstName;
            noti.Author.LastName = author.LastName;
            noti.Author.Avatar = author.Avatar;
            noti.LastModifiedAt = DateTime.Now;
            noti.NavigateId = result.NavigateId;
            var check = await _userConnectionManager.SaveNotification(noti);
            var connections = _userConnectionManager.GetUserConnections(result.Data);
            if (connections != null && connections.Count > 0)
            {
                foreach (var connectionId in connections)
                {

                    if (check != null)
                    {
                        noti.Id = check.Data.Id;
                        await _notificationUserHubContext.Clients.Client(connectionId).SendAsync("sendToUser", noti);
                    }
                }
            }
            return Ok(result);
        }

        [HttpGet("applied/{id}")]
        public async Task<IActionResult> ViewAppliedPost(int id, [FromQuery] PaginationFilter request)
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var result = await _contractorPostService.ViewAppliedPost(id, validFilter);
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] PaginationFilter request, [FromQuery] string? keyword = "")
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var result = await _contractorPostService.SearchPost(validFilter, keyword);
            return Ok(result);
        }

        [HttpGet("views")]
        public async Task<IActionResult> GetListByViews([FromQuery] PaginationFilter request)
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var result = await _contractorPostService.GetPostByViews(validFilter);
            return Ok(result);
        }
        [HttpPost("createPost")]
        public async Task<IActionResult> CreateContractorPost([FromBody] ContractorPostModels contractorPost)
        {
            BaseResponse<ContractorPostModels> response = new();
            var rs = await _contractorPostService.CreateContractorPost(contractorPost);
            if (rs)
            {
                response.Code = BaseCode.SUCCESS;
                response.Message = "Create Post success";
                response.Data = contractorPost;
            }
            else
            {
                response.Code = BaseCode.ERROR;
                response.Message = "Create Post fail";
            }
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost([FromRoute] int id)
        {
            var rs = await _contractorPostService.GetDetailPost(id);
            return Ok(rs);
        }

        [HttpGet("post/applied")]
        public async Task<IActionResult> ViewPostApplied([FromQuery] PaginationFilter request)
        {
            var id = User.FindFirst("UserID").Value;
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);

            var result = await _contractorPostService.ViewAllPostApplied(Guid.Parse(id), validFilter);
            return Ok(result);
        }

    }
}
