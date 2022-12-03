using Application.System.ContractorPosts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Filter;
using ViewModels.Pagination;

namespace BuildingConstructApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractorPostController : ControllerBase
    {
        private readonly IContractorPostService _contractorPostService;

        public ContractorPostController(IContractorPostService contractorPostService)
        {
            _contractorPostService = contractorPostService;
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

            var result = await _contractorPostService.GetPost(request);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Search([FromQuery] string keyword, [FromQuery] PaginationFilter request)
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var result = await _contractorPostService.SearchPost(validFilter, keyword);
            return Ok(result);
        }
    }
}
