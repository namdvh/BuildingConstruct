using Application.System.BuilderPosts;
using Application.System.Commitments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Pagination;

namespace BuildingConstructApi.Controllers
{
    [Route("api/commitment")]
    [ApiController]
    public class CommitmentController : ControllerBase
    {
        private readonly ICommitmentService _commitmentService;

        public CommitmentController(ICommitmentService commitmentService)
        {
            _commitmentService = commitmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationFilter request)
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var userID = User.FindFirst("UserID").Value;

            if(userID == null)
            {
                return BadRequest();
            }
            var result = await _commitmentService.GetCommitment(Guid.Parse(userID),validFilter);
            return Ok(result);
        }
    }
}
