using Application.System.MaterialStores;
using Data.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ViewModels.MaterialStore;
using ViewModels.Pagination;
using ViewModels.Response;

namespace BuildingConstructApi.Controllers
{
    [Route("api/store")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]

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
        public async Task<IActionResult> Search([FromQuery] PaginationFilter request, [FromQuery] string? keyword = "")
        {
            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            var result = await materialStoreService.Search(validFilter, keyword);
            return Ok(result);
        }
        [HttpPost("createProduct")]
        public async Task<IActionResult> AddProduct([FromBody] ProductDTO request)
        {
            BaseResponse<ProductDTO> response = new();
            var rs = await materialStoreService.CreateProduct(request);
            if (rs)
            {
                response.Code = BaseCode.SUCCESS;
                response.Message = BaseCode.SUCCESS_MESSAGE;
                response.Data = request;
            }
            else
            {
                response.Code = BaseCode.ERROR;
                response.Message = BaseCode.ERROR_MESSAGE;
            }
            return Ok(response);
        }
        [HttpGet("getProductDetail/{productId}")]
        public async Task<IActionResult> GetProductDetail([FromRoute] int productId)
        {
            var rs = await materialStoreService.GetProductDetail(productId);
            return Ok(rs);
        }
        [HttpDelete("deleteProduct/{productId}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int productId)
        {
            BaseResponse<ProductDTO> response = new();
            var rs = await materialStoreService.DeleteProduct(productId);
            if (rs)
            {
                response.Message = BaseCode.SUCCESS_MESSAGE;
                response.Code = BaseCode.SUCCESS;
            }
            else
            {
                response.Code = BaseCode.ERROR;
                response.Message = BaseCode.ERROR_MESSAGE;
            }
            return Ok(response);
        }
        [HttpPut("updateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductDTO request, int productId)
        {
            var rs = await materialStoreService.UpdateProduct(request,productId);
            return Ok(rs);
        }
        [HttpGet("getProductByUser")]
        public async Task<IActionResult> GetAllProductByUS([FromQuery] PaginationFilter request)
        {

            var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);

            var rs = await materialStoreService.GetAllProductStore(validFilter);
            return Ok(rs);
        }
    }
}
