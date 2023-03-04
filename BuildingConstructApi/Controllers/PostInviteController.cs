using Application.System.Bill;
using Application.System.PostInvite;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Identification;
using ViewModels.Pagination;
using ViewModels.PostInvite;

namespace BuildingConstructApi.Controllers
{
    [Route("api/invite")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class PostInviteController : ControllerBase
    {
        private readonly IPostInviteService postInviteService;

        public PostInviteController(IPostInviteService postInviteService)
        {
            this.postInviteService = postInviteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationFilter request)
        {
            var userID = User.FindFirst("UserID").Value;
            var result = await postInviteService.GetAll(request,Guid.Parse(userID));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePostIniviteRequest requests)
        {
            var result = await postInviteService.Create( requests);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id)
        {

            var result = await postInviteService.Update(id);
            return Ok(result);
        }
    }
}
