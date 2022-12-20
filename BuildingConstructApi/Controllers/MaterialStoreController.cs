using Application.System.BuilderPosts;
using Application.System.MaterialStores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Pagination;

namespace BuildingConstructApi.Controllers
{
    [Route("api/store")]
    [ApiController]
    public class MaterialStoreController : ControllerBase
    {
        private readonly IMaterialStoreService materialStoreService;

        public MaterialStoreController(IMaterialStoreService materialStoreService)
        {
            this.materialStoreService = materialStoreService;
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

            var result = await materialStoreService.GetList(request);
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search( [FromQuery] PaginationFilter request, [FromQuery] string? keyword = "")
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var result = await materialStoreService.Search(validFilter, keyword);
            return Ok(result);
        }
    }
}
