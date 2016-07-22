using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMvcWebApp.Patterns
{
    public interface IUnitOfWork : IDisposable
    {
        IProductsRepository ProductsRepository { get; set; }
        Task<int> SaveChanges();
    }
}
