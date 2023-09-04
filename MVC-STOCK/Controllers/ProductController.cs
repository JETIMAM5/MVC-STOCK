using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using MVC_STOCK.Models.Entity;

namespace MVC_STOCK.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index()
        {
            var products = db.TBLPRODUCTS.ToList();
            return View(products);
        }
        [HttpGet]
        public ActionResult NewProduct()
        {
            List<SelectListItem> values = (from i in db.TBLCATEGORIES.ToList()
                                           select new SelectListItem

                                           {
                                               Text = i.CATEGORYNAME,
                                               Value = i.CATEGORYID.ToString()
                                           }).ToList();
            ViewBag.vls=values;
            return View();
        }
        [HttpPost]
        public ActionResult NewProduct(TBLPRODUCTS product)
        {
            var ctg = db.TBLCATEGORIES.Where(m=>m.CATEGORYID==product.TBLCATEGORIES.CATEGORYID).FirstOrDefault();
            product.TBLCATEGORIES = ctg;

            db.TBLPRODUCTS.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int id) 
        {
            var product = db.TBLPRODUCTS.Find(id);
            db.TBLPRODUCTS.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BringProduct(int id) 
        {
        var product = db.TBLPRODUCTS.Find(id);
            List<SelectListItem> values = (from i in db.TBLCATEGORIES.ToList()
                                           select new SelectListItem

                                           {
                                               Text = i.CATEGORYNAME,
                                               Value = i.CATEGORYID.ToString()
                                           }).ToList();
            ViewBag.vls = values;
           
            return View("BringProduct", product);
        }
        public ActionResult Update(TBLPRODUCTS p1) 
        {
            var prd = db.TBLPRODUCTS.Find(p1.PRODID);
            prd.PRODNAME = p1.PRODNAME;
            prd.PRICE = p1.PRICE;
            prd.BRAND = p1.BRAND;
            //prd.PRODCATEGORY = p1.PRODCATEGORY;
            var ctg = db.TBLCATEGORIES.Where(m => m.CATEGORYID == p1.TBLCATEGORIES.CATEGORYID).FirstOrDefault();
            prd.PRODCATEGORY = ctg.CATEGORYID;
            prd.STOCK=p1.STOCK;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}