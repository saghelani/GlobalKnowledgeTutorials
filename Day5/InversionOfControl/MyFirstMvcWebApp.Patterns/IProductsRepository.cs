using MyFirstMvcWebApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMvcWebApp.Patterns
{
    public interface IProductsRepository
    {
        Task<IList<Product>> GetProducts();

        Task<Product> GetProduct(int id);

        Product UpdateProduct(Product product);
    }
}
