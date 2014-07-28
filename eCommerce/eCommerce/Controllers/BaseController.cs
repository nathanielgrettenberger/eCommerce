using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class BaseController : Controller
       
    {
         //property to get our order
        private Models.Order _myOrder;
        public Models.Order MyOrder
        {
            get{
                // see if _myOrder is null
                if(_myOrder == null)
                {
                    _myOrder = db.Orders.Find(GetOrderID());

                
                }
                return _myOrder;
                }
        }
        // set up a data base connection
     public  Models.eCommerceEntities db = new Models.eCommerceEntities();
        public int GetOrderID()
        {
            
            if (Session["orderID"] == null)
            {
                //they dont have a cart
                //create a new order
                // make a new order object
                Models.Order order = new Models.Order();
                // fillin teh required information
                order.DateCreated = DateTime.Now;
                order.Status = "Cart";
                order.Tax = 0;
                order.TotalPrice = 0;
                order.ShippingTotal = 0;
                // add order to database
                db.Orders.Add(order);
                //save changes
                db.SaveChanges();
                Session["orderID"] = order.OrderID;
            }
            return int.Parse(Session["orderID"].ToString());
        }
    }
}
