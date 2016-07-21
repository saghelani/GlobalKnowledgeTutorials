using MyFirstMvcWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMvcWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IEnumerable<Customer> customers = new List<Customer>
            {
                new Customer { CustomerId = "ALFKI", CustomerName = "Queen Elizabeth", City = "London" },
                new Customer { CustomerId = "ANATR", CustomerName = "Prince Charles", City = "London" },
                new Customer { CustomerId = "HARRY", CustomerName = "Prince Harry", City = "London" }
            };

        // GET: Home
        public ActionResult Index()
        {
            return View(customers);
            //var result = new ContentResult();
            //result.Content = "<h1>Hello MVC</h1>";
            //return result;
        }

        public ActionResult Edit(string id)
        {
            var customer = customers.SingleOrDefault(c => c.CustomerId == id);
            return View(customer);
        }
    }
}