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
        private Response res;

        // GET: api/<CustomerController>
        [HttpGet]
        public Response Get()
        {
            using (var _db = new kShopContext())
            {
                try
                {
                    
                    res = new Response() { Data = _db.Customers.ToList(), Message = "Success", Status = 200, ResponseTime = DateTime.Now };
                }
                catch (Exception ex)
                {
                    res = new Response() { Data = null, Message = ex.Message, Status = 500, ResponseTime = DateTime.Now };

                }

                return res;
            }
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Response Get(int id)
        {
            using (var _db = new kShopContext())
            {
                try
                {

                    res = new Response() { Data = _db.Customers.Find(id), Message = "Success", Status = 200, ResponseTime = DateTime.Now };
                }
                catch (Exception ex)
                {
                    res = new Response() { Data = null, Message = ex.Message, Status = 500, ResponseTime = DateTime.Now };

                }
                return res;
            }
        }

        // POST api/<CustomerController>
        [HttpPost]
        public Response Post([FromBody] Customer value)
        {
            using (var _db = new kShopContext())
            {
                try
                {
                    if(_db.Customers.Any(o=>o.CustomerId == value.CustomerId))
                    {
                        _db.Update(value);
                        _db.SaveChanges();
                        res = new Response() { Data = null, Message = "Update Success", Status = 200, ResponseTime = DateTime.Now };

                    }
                    else
                    {
                        _db.Add(value);
                        _db.SaveChanges();
                        res = new Response() { Data = null, Message = "Save Success", Status = 200, ResponseTime = DateTime.Now };

                    }

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
