using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_STOCK.Models.Entity;

namespace MVC_STOCK.Controllers
{
    public class CustomerController : Controller
    {
        MvcDbStockEntities db = new MvcDbStockEntities();
        // GET: Customer
        public ActionResult Index(string p)
        {
            // var customer = db.TBLCUSTOMERS.ToList();
            //return View(customer);
            var values = from d in db.TBLCUSTOMERS select d;
            if (!string.IsNullOrEmpty(p))
            {
                values = values.Where(m => m.CUSTOMERNAME.Contains(p));
            }

            return View(values.ToList());
        }
        [HttpGet]
        public ActionResult NewCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCustomer(TBLCUSTOMERS customer)
        {
            if (!ModelState.IsValid)
            {
                return View("NewCustomer");
            }
            db.TBLCUSTOMERS.Add(customer);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeleteCustomer(int id)
        {
            var customer = db.TBLCUSTOMERS.Find(id);
            db.TBLCUSTOMERS.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetCustomer(int id)
        {
            var customer = db.TBLCUSTOMERS.Find(id);
            return View("GetCustomer", customer);
        }
        public ActionResult UpdateCustomer(TBLCUSTOMERS p1)
        {
            var customer = db.TBLCUSTOMERS.Find(p1.CUSTOMERID);
            customer.CUSTOMERNAME = p1.CUSTOMERNAME;
            customer.CUSTOMERSURNAME = p1.CUSTOMERSURNAME;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}