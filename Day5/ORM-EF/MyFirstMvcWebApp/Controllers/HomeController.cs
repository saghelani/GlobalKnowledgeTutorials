using MyFirstMvcWebApp.Data.EF;
using MyFirstMvcWebApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMvcWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {            
            using (var context = new ProductsDb())
            {
                List<Product> model = context.Products
                    .OrderBy(p => p.ProductName)
                    .ToList();
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            using (var context = new ProductsDb())
            {
                var model = context.Products
                    .SingleOrDefault(p => p.ProductId == id);
                return View(model); 
            }
        }
    }
}