using kShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace kShop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductSetupController : ControllerBase
    {
        private Response res;

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public Response Post([FromBody] Product value)
        {
            using (var _db = new kShopContext())
            {
                try
                {
                    _db.Add(value);
                    _db.SaveChanges();
                    res = new Response() { Data = null, Message = "Success", Status = 200, ResponseTime = DateTime.Now };
                }
                catch (Exception ex)
                {
                    res = new Response() { Data = null, Message = ex.Message, Status = 500, ResponseTime = DateTime.Now };

                }

                return res;
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
