using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfiniteScroll_UsingJquery.Models;
using Newtonsoft.Json;

namespace InfiniteScroll_UsingJquery.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        CustomerDbEntities _context = new CustomerDbEntities();

        public ActionResult Index()
        {
           var customer = _context.Customers.ToList();
           return View(customer);

            ////////////////this is not complete program. 
        }


        public ActionResult LoadMoreCustomer(int startfrom, int count)
        {
            //var customerdata = (from customer in _context.Customers select customer).ToList();
            var customerdata = _context.USP_GETCustomer(startfrom,count);          
            return Json(customerdata, JsonRequestBehavior.AllowGet);
        }

    }
}