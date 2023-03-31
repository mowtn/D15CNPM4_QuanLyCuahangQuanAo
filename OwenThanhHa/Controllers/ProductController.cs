using OwenThanhHa.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OwenThanhHa.Models;
namespace OwenThanhHa.Controllers
{
    public class ProductController : Controller
    {
        ThanhHaShopEntities2 obj = new ThanhHaShopEntities2();
        // GET: Product
       
        public ActionResult Product(int id)
        {
            var product = obj.Products.Where(m => m.Id == id).FirstOrDefault();
            var objproducts = obj.Products.Where(m=>m.CategoryId == product.CategoryId).ToList();
            Product_category objProduct_category = new Product_category();
            objProduct_category.product = product;
            objProduct_category.Listproducts = objproducts;
            return View(objProduct_category);
        }
        public ActionResult searchProduct(string searchstring)
        {
            var listproducts = new List<Product>();
            if (!string.IsNullOrEmpty(searchstring))
            {
                //lấy ds sản phẩm theo từ khóa tìm kiếm
                listproducts = obj.Products.Where(m => m.Name.Contains(searchstring)).ToList();
            }
            return View(listproducts);
        }
    }
}