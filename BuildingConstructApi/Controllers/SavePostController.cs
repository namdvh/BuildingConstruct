using Application.System.SavePost;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Response;
using ViewModels.SavePost;

namespace BuildingConstructApi.Controllers
{
    [Route("api/savepost")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class SavePostController : ControllerBase
    {
        private readonly ISaveService _saveService;

        public SavePostController(ISaveService saveService)
        {
            _saveService = saveService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTypeAndSkill()
        {
            var rs = await _saveService.GetSavePostByUsID();
            return Ok(rs);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSavePost([FromBody] SavePostRequest request)
        {
            var rs = await _saveService.SavePost(request);
            return Ok(rs);
        }
        [HttpPut]
        public async Task<IActionResult> DeleteSave([FromBody] DeleteSaveRequest request)
        {
            BaseResponse<string> response = new();
            var rs = await _saveService.DeleteSave(request);
            if (rs)
            {
                response.Code = "200";
                response.Message = "Delete repost succesfully";
            }
            else
            {
                response.Code = "202";
                response.Message = "Delete repost unsuccesfully";
            }
            return Ok(response);
        }
    }
}
