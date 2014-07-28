using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class CartController : BaseController
    {
        //
        // GET: /Cart/

        public ActionResult Index()
        {
            return View();
        }
        //Get /Cart/MiniCart
        public ActionResult MiniCart()
        {
            return PartialView(this.MyOrder);
        
        }
        [HttpPost]
        public ActionResult Add(Models.OrderLine ol)
         
        {
            if(this.MyOrder.OrderLines.Where(x=> x.ProductID == ol.ProductID).Any())
            {
                // get the order line to update the quanity
                var cartItem=this.MyOrder.OrderLines.Where(x=> x.ProductID == ol.ProductID).First();
                // update the Qty
                cartItem.Qty = cartItem.Qty + ol.Qty;
            }
            this.MyOrder.OrderLines.Add(ol);
            db.SaveChanges();
            return RedirectToAction("MiniCart", "Cart");
        }

    }
}
