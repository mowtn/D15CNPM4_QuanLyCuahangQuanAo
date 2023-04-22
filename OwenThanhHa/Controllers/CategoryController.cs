using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OwenThanhHa.Context;
namespace OwenThanhHa.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult CategoryShow(int id)
        {
            ThanhHaShopEntities2 ThanhHaEntini = new ThanhHaShopEntities2();
            var listProduct = ThanhHaEntini.Products.Where(m => m.CategoryId == id).ToList();
            return View(listProduct);
        }
    }
}