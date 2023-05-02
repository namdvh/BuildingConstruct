using Application.System.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Types;

namespace BuildingConstructApi.Controllers
{
    [Route("api/type")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly ITypeService _typeService;

        public TypeController(ITypeService typeService)
        {
            _typeService = typeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTypeAndSkill()
        {
            var rs =await _typeService.GetAllTypeAndSkills();
            return Ok(rs);
        }
        [HttpGet("getAllTypeAndSkillAdmin")]
        public async Task<IActionResult> GetAllTypeAndSkillForAdmin()
        {
            var rs = await _typeService.GetAllTypeAndSkillsAdmin();
            return Ok(rs);
        }
        [HttpPost]
        public async Task<IActionResult> CreateType(TypeRequest type)
        {
            var rs = await _typeService.CreateType(type);
            return Ok(rs);
        }
        [HttpPut("deactive")]
        public async Task<IActionResult> DeleteType (string typeId)
        {
            var rs = await _typeService.DeleteType(typeId);
            return Ok(rs);
        }
        [HttpPut("active")]
        public async Task<IActionResult> ActiveType(string typeId)
        {
            var rs = await _typeService.ActiveType(typeId);
            return Ok(rs);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateType([FromBody]TypeRequest type)
        {
            var rs = await _typeService.UpdateType(type);
            return Ok(rs);
        }
    }
}
