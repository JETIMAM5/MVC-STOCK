using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_STOCK.Models.Entity;

namespace MVC_STOCK.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index()
        {
            var categories = db.TBLCATEGORIES.ToList();
            return View(categories);
        }
        [HttpGet]
        public ActionResult NewCategory() 
        {
        return View();
        }

        [HttpPost]
        public ActionResult NewCategory(TBLCATEGORIES p1)
        {
            if (!ModelState.IsValid)
            {
                return View("NewCategory");
            }
            db.TBLCATEGORIES.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeleteCategory(int id) 
        {
            var category = db.TBLCATEGORIES.Find(id);
            db.TBLCATEGORIES.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        
        }
        public ActionResult BringCategory(int id) 
        {
            var category = db.TBLCATEGORIES.Find(id);
            return View("BringCategory",category);
        }
        public ActionResult Update(TBLCATEGORIES p1) 
        {
            var category = db.TBLCATEGORIES.Find(p1.CATEGORYID);
            category.CATEGORYNAME= p1.CATEGORYNAME;
            db.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}