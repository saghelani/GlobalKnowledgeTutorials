using MyFirstMvcWebApp.Data.EF;
using MyFirstMvcWebApp.Entities;
using MyFirstMvcWebApp.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMvcWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository productsRepository = new ProductsRepository();
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var model = await productsRepository.GetProducts();
            return View(model);
        }

        public async Task<ActionResult> Edit(int id)
        {
            var model = await productsRepository.GetProduct(id);
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Edit([Bind(Include ="ProductId,ProductName,UnitPrice")] Product product)
        {
            if (ModelState.IsValid)
            {
                await productsRepository.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}