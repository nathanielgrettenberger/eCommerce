using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace eCommerce.Controllers
{

    public class HomeController : BaseController
    {
    
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
