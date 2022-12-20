using Application.System.BuilderPosts;
using Application.System.ContractorPosts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Pagination;

namespace BuildingConstructApi.Controllers
{
    [Route("api/builderpost")]
    [ApiController]
    public class BuilderPostController : ControllerBase
    {
        private readonly IBuilderPostService _builderPostService;

        public BuilderPostController(IBuilderPostService builderPostService)
        {
            _builderPostService = builderPostService;
        }

        [HttpPost]
        public async Task<IActionResult> GetAll([FromBody] PaginationFilter request)
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

            var result = await _builderPostService.GetPost(request);
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] PaginationFilter request, [FromQuery] string? keyword = "")
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var result = await _builderPostService.SearchPost(validFilter, keyword);
            return Ok(result);
        }

        [HttpGet("views")]
        public async Task<IActionResult> GetListByViews([FromQuery] PaginationFilter request)
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var result = await _builderPostService.GetPostByViews(validFilter);
            return Ok(result);
        }
    }
}
