using kShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace kShop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        Response res;

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public Response Post([FromBody] Customer value)
        {
            using (var _db = new kShopContext())
            {
                try
                {
                    _db.Add(value);
                    _db.SaveChanges();
                     res = new Response() { Data = null, Message = "Success", Status = 200, ResponseTime = DateTime.Now };
                }
                catch(Exception ex)
                {
                    res = new Response() { Data = null, Message = ex.Message, Status = 500, ResponseTime = DateTime.Now };

                }

                return res;
            }

        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
