using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class HomeController : Controller
    {
        Models.eCommerceEntities db = new Models.eCommerceEntities();
        public ActionResult Index()
        {
           

            return View(db.Products.OrderByDescending(x=> x.UnitPrice));
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            
            return View();
        }
    }
}
