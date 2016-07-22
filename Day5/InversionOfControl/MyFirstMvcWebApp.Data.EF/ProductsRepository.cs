using MyFirstMvcWebApp.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMvcWebApp.Entities;
using System.Data.Entity;

namespace MyFirstMvcWebApp.Data.EF
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductsDb context;

        public ProductsRepository(ProductsDb context)
        {
            this.context = context;
        }

        //using async to do this asynchrously and hence return type is Task and requires await in method
        public async Task<Product> GetProduct(int id)
        {
            var model = await context.Products
                .SingleOrDefaultAsync(p => p.ProductId == id);
            return model;
        }

        public async Task<IList<Product>> GetProducts()
        {
            List<Product> model = await context.Products
                .OrderBy(p => p.ProductName)
                .ToListAsync();
            return model;
        }

        public Product UpdateProduct(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
            return product;
        }
    }
}
