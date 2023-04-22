using OwenThanhHa.Context;
using OwenThanhHa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwenThanhHa.Controllers
{
    public class PaymentController : Controller
    {
        ThanhHaShopEntities2 obj = new ThanhHaShopEntities2();
        // GET: Payment
        public ActionResult Index()
        {
            if(Session["id"] == null)
            {
                return RedirectToAction("Login","Home");
            }
            else
            {
                //gán dữ liệu cho bảng order
                Order objOrder = new Order();
                objOrder.Name = "DonHang" + DateTime.Now.ToString("yyyyMMddHHmmss");
                objOrder.CreatedOnUTc = DateTime.Now;
                objOrder.Status = 1;
                objOrder.UserID = int.Parse(Session["id"].ToString());
                obj.Orders.Add(objOrder);
                obj.SaveChanges();
                int IdOrder = objOrder.Id;
                //lấy thông tin các từ giỏ hàngh từ biến session
                var listCart = (List<CartModel>)Session["cart"];
                //khai báo 1 list để gán list các sản phẩm lấy từ giỏ hàng
                List<OrderProduct> LstOrderProduct = new List<OrderProduct>();
                foreach(var item in listCart)
                {
                    OrderProduct objorderproduct = new OrderProduct();
                    objorderproduct.OrderId = IdOrder;
                    objorderproduct.ProductId = item.product.Id;
                    objorderproduct.Quantity = item.Quantity;
                    
                    LstOrderProduct.Add(objorderproduct);
                }
                obj.OrderProducts.AddRange(LstOrderProduct);
                obj.SaveChanges();
            }
            return View();
        }

        public ActionResult showYourOrder(int id)
        {
            Order_ProductOfUser opp = new Order_ProductOfUser();
            opp.Listorder = obj.Orders.Where(m => m.UserID == id).ToList();
            opp.Listorderproduct = obj.OrderProducts.ToList();
            opp.Listproducts = obj.Products.ToList();
            return View(opp);
        }
        public ActionResult changeStatus(int id)
        {

            Order_ProductOfUser opp = new Order_ProductOfUser();
            opp.orderitem = obj.Orders.Where(m => m.Id == id).FirstOrDefault();
            opp.Listorderproduct = obj.OrderProducts.ToList();
            opp.Listproducts = obj.Products.ToList();
            return View(opp);
        }



    }
}