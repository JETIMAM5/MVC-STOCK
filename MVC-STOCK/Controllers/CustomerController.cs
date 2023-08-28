﻿using System;
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
        public ActionResult Index()
        {
            var customer = db.TBLCUSTOMERS.ToList();
            return View(customer);
        }
    }
}