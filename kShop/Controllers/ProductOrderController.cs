using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace kShop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductOrderController : ControllerBase
    {
        // GET: api/<ProductOrderController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductOrderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductOrderController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductOrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductOrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
