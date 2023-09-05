using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_STOCK.Models.Entity;

namespace MVC_STOCK.Controllers
{
    public class SalesController : Controller
    {
        MvcDbStockEntities db = new MvcDbStockEntities();
        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult NewSale()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewSale(TBLSALES p)
        {
            db.TBLSALES.Add(p);
            db.SaveChanges();
            return View("Index");
        }
    }
}