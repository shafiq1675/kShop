using System;
using System.Collections.Generic;

#nullable disable

namespace kShop.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? SetDate { get; set; }
    }
}
