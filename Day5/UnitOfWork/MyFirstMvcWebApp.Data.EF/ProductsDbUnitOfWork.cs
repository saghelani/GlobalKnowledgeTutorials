using MyFirstMvcWebApp.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMvcWebApp.Data.EF
{
    public class ProductsDbUnitOfWork : IUnitOfWork
    {
        private readonly ProductsDb context = new ProductsDb();

        public IProductsRepository ProductsRepository { get; set; }

        public ProductsDbUnitOfWork()
        {
            ProductsRepository = new ProductsRepository(context);
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                IDisposable disposable = context as IDisposable;
                disposable?.Dispose();

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
