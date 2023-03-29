using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BuildingConstructApi.Controllers
{
    [Route("testing")]
    [ApiController]
    public class testing : ControllerBase
    {
        // GET: api/testing
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<testing>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<testing>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<testing>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<testing>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
