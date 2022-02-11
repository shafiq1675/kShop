using kShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public Response Get()
        {
            using (var _db = new kShopContext())
            {
                try
                {

                    res = new Response() { Data = _db.Products.ToList(), Message = "Success", Status = 200, ResponseTime = DateTime.Now };
                }
                catch (Exception ex)
                {
                    res = new Response() { Data = null, Message = ex.Message, Status = 500, ResponseTime = DateTime.Now };

                }

                return res;
            }
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Response Get(string id)
        {
            using (var _db = new kShopContext())
            {
                try
                {

                    res = new Response() { Data = _db.Products.Find(id), Message = "Success", Status = 200, ResponseTime = DateTime.Now };
                }
                catch (Exception ex)
                {
                    res = new Response() { Data = null, Message = ex.Message, Status = 500, ResponseTime = DateTime.Now };

                }
                return res;
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        public Response Post([FromBody] Product value)
        {
            using (var _db = new kShopContext())
            {
                try
                {
                    if (_db.Products.Any(item => item.ProductId == value.ProductId))
                    {
                        _db.Update(value);
                        _db.SaveChanges();
                        res = new Response() { Data = null, Message = "Update Success", Status = 200, ResponseTime = DateTime.Now };
                    }
                    else {
                        _db.Add(value);
                        _db.SaveChanges();
                        res = new Response() { Data = null, Message = "Save Success", Status = 200, ResponseTime = DateTime.Now };
                    }
                    
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
