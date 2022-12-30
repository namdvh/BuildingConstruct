using Application.System.ContractorPosts;
using Data.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels.ContractorPost;
using ViewModels.Filter;
using ViewModels.Pagination;
using ViewModels.Response;

namespace BuildingConstructApi.Controllers
{
    [Route("api/contractorpost")]
    [ApiController]
    public class ContractorPostController : ControllerBase
    {
        private readonly IContractorPostService _contractorPostService;

        public ContractorPostController(IContractorPostService contractorPostService)
        {
            _contractorPostService = contractorPostService;
        }

        [HttpPost("getAll")]
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

            var result = await _contractorPostService.GetPost(request);
            return Ok(result);
        }

        [HttpPost("applied")]
        public async Task<IActionResult> AppliedPost([FromBody] AppliedPostRequest request)
        {
            var rs = User.FindFirst("UserID").Value;

            var result = await _contractorPostService.AppliedPost(request,Guid.Parse(rs));
            return Ok(result);
        }

        [HttpGet("applied/{id}")]
        public async Task<IActionResult> AppliedPost(int id, [FromQuery] PaginationFilter request)
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var result = await _contractorPostService.ViewAppliedPost(id,validFilter);
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search( [FromQuery] PaginationFilter request, [FromQuery] string? keyword = "")
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
        public async Task<IActionResult> GetPost([FromRoute]int id)
        {
            var rs = await _contractorPostService.GetDetailPost(id);
            return Ok(rs);
        }

    }
}
