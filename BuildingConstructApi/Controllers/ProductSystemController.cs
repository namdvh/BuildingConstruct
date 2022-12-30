using Application.System.ProductSystems;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Pagination;
using ViewModels.ProductSystems;
using ViewModels.Response;

namespace BuildingConstructApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSystemController : ControllerBase
    {
        private readonly IProductSystemService _productSystemService;

        public ProductSystemController(IProductSystemService productSystemService)
        {
            _productSystemService = productSystemService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductSystem([FromBody] ProductSystemDTO request)
        {
            BaseResponse<string> response = new();
            var rs = await _productSystemService.CreateProductSystems(request);
            if (rs)
            {
                response.Code = "200";
                response.Message = "Create succesfully";
            }
            else
            {
                response.Code = "202";
                response.Message = "Create unsuccesfully";
            }
            return Ok(response);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllProductSystems([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, "Id", filter._orderBy);
            var rs = await _productSystemService.GetAllProducSystems(validFilter);
            return Ok(rs);
        }
    }
}
