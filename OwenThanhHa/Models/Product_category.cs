using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OwenThanhHa.Context;

namespace OwenThanhHa.Models
{
    public class Product_category
    {
        public IEnumerable<Product> Listproducts{get; set;}
        public IEnumerable<Category> Listcategorys { get; set; }
        public Product product { get; set; }
        public Category category { get; set; }
    }
}