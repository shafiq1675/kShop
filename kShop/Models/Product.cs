using System;
using System.Collections.Generic;

#nullable disable

namespace kShop.Models
{
    public partial class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public decimal ProductPrice { get; set; }
        public string Description { get; set; }
        public DateTime? SetDate { get; set; }
    }
}
