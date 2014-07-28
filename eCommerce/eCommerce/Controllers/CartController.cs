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

    }
}
