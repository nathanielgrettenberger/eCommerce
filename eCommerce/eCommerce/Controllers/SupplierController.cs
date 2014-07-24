using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace eCommerce.Controllers
{
    public class SupplierController : Controller
    {
        Models.eCommerceEntities db = new Models.eCommerceEntities();
        //
        // GET: /Supplier/

        public ActionResult Index()
        {
            return View(db.Suppliers);
        }
        // Get: post/create
        [HttpGet]
        public ActionResult Create()
        {
            // pass a blank post
            return View(new Models.Supplier());

        }
        [HttpPost]
        // public
        public ActionResult Create(Models.Supplier supplier)
        {
            
            //save it to that data base
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            // kick user back to thi post
            return RedirectToAction("Index", "Suppliers");
        }
        //GET: /Post/Delete/{if}
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Models.Supplier postToDelete = db.Suppliers.Find(id);
            return View(postToDelete);


        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        // get post from dadt base
        {
            Models.Supplier postToDelete = db.Suppliers.Find(id);
            // delete the post from the database
            db.Suppliers.Remove(postToDelete);
            db.SaveChanges();
            return RedirectToAction("Index", "Suppliers");

        }
        public ActionResult Edit(int id)
        {
            Models.Supplier SuppliersToEdit = db.Suppliers.Find(id);
            return View(SuppliersToEdit);

        }
        [HttpPost]
        public ActionResult Edit(Models.Supplier postToEdit)
        {
            db.Entry(postToEdit).State = System.Data.EntityState.Modified;
            // kick them back to th

            //saveChanges();  
            db.SaveChanges();
            return RedirectToAction("Index", "Suppliers");

        }
        
    }
}
