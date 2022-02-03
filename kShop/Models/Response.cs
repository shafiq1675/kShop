using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kShop.Models
{
    public class Response
    {
        public int Status { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public DateTime ResponseTime { get; set; }

        public Response(int Status = 0, string Message = "", object Object = null)
        {
            this.Status = Status;
            this.Message = Message;
            this.Data = Object;
            this.ResponseTime = DateTime.Now;
        }
    }
}
