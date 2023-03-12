using OwenThanhHa.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OwenThanhHa.Models
{
    public class Order_ProductOfUser
    {
        public IEnumerable<Product> Listproducts { get; set; }
        public IEnumerable<Order> Listorder { get; set; }
        public Order orderitem { get; set; }
        public IEnumerable<OrderProduct> Listorderproduct { get; set; }
        public IEnumerable<User> ListUser { get; set; }
    }
}