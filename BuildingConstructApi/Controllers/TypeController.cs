using Application.System.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
