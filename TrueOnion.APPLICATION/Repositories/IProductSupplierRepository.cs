using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Repositories
{
    public interface IProductSupplierRepository : IGenericRepository<ProductSupplier>
    {
        //        public Task<IEnumerable<Product>> GetProductsWithCategory();

        public Task<IEnumerable<ProductSupplier>> GetProductSupplierWithProductAndSupplier();
    }
}
