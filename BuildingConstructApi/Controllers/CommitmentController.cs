using Application.System.Commitments;
using Data.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Commitment;
using ViewModels.Pagination;

namespace BuildingConstructApi.Controllers
{
    [Route("api/commitment")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class CommitmentController : ControllerBase
    {
        private readonly ICommitmentService _commitmentService;

        public CommitmentController(ICommitmentService commitmentService)
        {
            _commitmentService = commitmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationFilter request,Status status)
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var userID = User.FindFirst("UserID").Value;

            if (userID == null)
            {
                return BadRequest();
            }
            var result = await _commitmentService.GetCommitment(Guid.Parse(userID), validFilter,status);
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
        public async Task<IActionResult> GetData(int postID,int builderID)
        {
            var userID = User.FindFirst("UserID").Value;

            if (userID == null)
            {
                return BadRequest();
            }
            var result = await _commitmentService.GetDetailForCreate(postID,builderID,Guid.Parse(userID));
            return Ok(result);
        }

        [HttpPut("{commitmentID}")]
        public async Task<IActionResult> UpdateCommitment([FromRoute]int commitmentID)
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
            var result = await _commitmentService.CreateCommitment(request,Guid.Parse(contractorID));
            return Ok(result);
        }
    }
}
