using Application.System.BuilderPosts;
using Application.System.ContractorPosts;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels.BuilderPosts;
using ViewModels.Pagination;
using ViewModels.Response;

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
        [HttpPost("createPost")]
        public async Task<IActionResult> CreateBuilderPost([FromBody] BuilderPostRequestDTO builderPost)
        {
            BaseResponse<BuilderPostRequestDTO> response = new();
            var rs = await _builderPostService.CreateBuilderPost(builderPost);
            if (rs)
            {
                response.Code = BaseCode.SUCCESS;
                response.Message = "Create Post success";
                response.Data = builderPost;
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
            var rs = await _builderPostService.GetDetailPost(id);
            return Ok(rs);
        }
    }
}
