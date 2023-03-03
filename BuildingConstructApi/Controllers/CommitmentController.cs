using Application.System.Commitments;
using Application.System.Notifies;
using BuildingConstructApi.Hubs;
using Data.DataContext;
using Data.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using ViewModels.Commitment;
using ViewModels.Notificate;
using ViewModels.Pagination;

namespace BuildingConstructApi.Controllers
{
    [Route("api/commitment")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class CommitmentController : ControllerBase
    {
        private readonly ICommitmentService _commitmentService;
        private readonly IHubContext<NotificationUserHub> _notificationUserHubContext;
        private readonly IUserConnectionManager _userConnectionManager;
        private readonly BuildingConstructDbContext _context;

        public CommitmentController(ICommitmentService commitmentService, IUserConnectionManager userConnectionManager, BuildingConstructDbContext context, IHubContext<NotificationUserHub> notificationUserHubContext)
        {
            _commitmentService = commitmentService;
            _userConnectionManager = userConnectionManager;
            _context = context;
            _notificationUserHubContext = notificationUserHubContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationFilter request, Status status)
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var userID = User.FindFirst("UserID").Value;

            if (userID == null)
            {
                return BadRequest();
            }
            var result = await _commitmentService.GetCommitment(Guid.Parse(userID), validFilter, status);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetail([FromRoute] int id)
        {
            var userID = User.FindFirst("UserID").Value;

            if (userID == null)
            {
                return BadRequest();
            }
            var result = await _commitmentService.GetDetailCommitment(id);
            return Ok(result);
        }
        [HttpGet("load")]
        public async Task<IActionResult> GetData(int postID, int builderID)
        {
            var userID = User.FindFirst("UserID").Value;

            if (userID == null)
            {
                return BadRequest();
            }
            var result = await _commitmentService.GetDetailForCreate(postID, builderID, Guid.Parse(userID));
            return Ok(result);
        }

        [HttpPut("{commitmentID}")]
        public async Task<IActionResult> UpdateCommitment([FromRoute] int commitmentID)
        {
            var userID = User.FindFirst("UserID").Value;

            if (userID == null)
            {
                return BadRequest();
            }
            var result = await _commitmentService.UpdateCommitment(Guid.Parse(userID), commitmentID);
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "Contractor")]
        public async Task<IActionResult> CreateCommitment([FromBody] CreateCommimentRequest request)
        {
            var contractorID = User.FindFirst("UserID").Value;

            if (contractorID == null)
            {
                return BadRequest();
            }
            var result = await _commitmentService.CreateCommitment(request, Guid.Parse(contractorID));
            var connections = _userConnectionManager.GetUserConnections(result.Data);
            NotificationModels noti = new();
            noti.NotificationType = NotificationType.TYPE_2;
            noti.Message = NotificationMessage.SAVENOTI;
            noti.CreateBy = Guid.Parse(contractorID.ToString());
            var author = await _context.Users.Where(x=>x.Id.ToString().Equals(noti.CreateBy.ToString())).FirstOrDefaultAsync();
            noti.Author = new();
            noti.Author.FirstName = author.FirstName;
            noti.Author.LastName = author.LastName;
            noti.Author.Avatar = author.Avatar;
            noti.LastModifiedAt = DateTime.Now;
            noti.NavigateId = result.NavigateId;
            var check = await _userConnectionManager.SaveNotification(noti);
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
    }
}


