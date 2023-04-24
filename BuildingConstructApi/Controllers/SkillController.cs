using Application.System.Skills;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Cryptography;
using ViewModels.Pagination;
using ViewModels.Skills;

namespace BuildingConstructApi.Controllers
{
    [Route("api/skills")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll([FromQuery] PaginationFilter request)
        {
            dynamic validFilter;

            if (request.FilterRequest == null)
            {
                validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy);
            }
            else
            {
                validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request._sortBy, request._orderBy, request.FilterRequest);

            }

            var result = await _skillService.GetAll(validFilter);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSkill(SkillRequest skill)
        {
            var rs = await _skillService.CreateSkill(skill);
            return Ok(rs);
        }
        [HttpPut("delete")]
        public async Task<IActionResult> DeleteSkill(int skillId)
        {
            var rs = await _skillService.DeleteSkill(skillId);
            return Ok(rs);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateSkill([FromBody] SkillRequest skill)
        {
            var rs = await _skillService.UpdateSkill(skill);
            return Ok(rs);
        }

        [HttpGet("test")]
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromQuery] string pic1, [FromQuery] string pic2)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://face-verification2.p.rapidapi.com/faceverification"),
                Headers =
    {
        { "X-RapidAPI-Key", "0af973177dmsh33b9953ecf57384p18ca21jsn3df8789084ce" },
        { "X-RapidAPI-Host", "face-verification2.p.rapidapi.com" },
    },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "linkFile1", pic1 },
        { "linkFile2", pic2 },
    }),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                
                dynamic stuff = JsonConvert.DeserializeObject(body);
                string test = stuff.data.resultMessage;
                double percent = stuff.data.similarPercent;
                var finalNumber = Math.Round(percent, 2) *100;
                Console.WriteLine(body);
               
            }

            return Ok();
        }
    }
}
