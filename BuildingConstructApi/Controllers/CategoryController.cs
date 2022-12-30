using Application.System.Category;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Categories;
using ViewModels.Response;

namespace BuildingConstructApi.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpPost]
        public async Task<IActionResult> createCategory([FromBody] CategoryDTO request)
        {
            BaseResponse<CategoryDTO> response = new();
            var rs = await _categoryService.CreateCategory(request);
            if (rs)
            {
                response.Data = request;
                response.Code = BaseCode.SUCCESS;
                response.Message = BaseCode.SUCCESS_MESSAGE;
            }
            else
            {
                response.Data = null;
                response.Code = BaseCode.ERROR;
                response.Message = BaseCode.ERROR_MESSAGE;
            }
            return Ok(response);
        }
    }
}
