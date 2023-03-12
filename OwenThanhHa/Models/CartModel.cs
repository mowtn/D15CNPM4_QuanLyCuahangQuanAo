using OwenThanhHa.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwenThanhHa.Models
{
    public class CartModel
    {
        public Product product { get; set; }
        public List<Product> listpro { get; set; }
        public int Quantity { get; set; }
    }
}