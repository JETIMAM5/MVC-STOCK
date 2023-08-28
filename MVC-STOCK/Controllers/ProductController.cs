using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_STOCK.Models.Entity;

namespace MVC_STOCK.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        MvcDbStockEntities db   = new MvcDbStockEntities(); 
        public ActionResult Index()
        {
            var products = db.TBLPRODUCTS.ToList();
            return View(products);
        }
    }
}