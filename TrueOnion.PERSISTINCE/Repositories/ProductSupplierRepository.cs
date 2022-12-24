using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.PERSISTINCE.Context;

namespace TrueOnion.PERSISTINCE.Repositories
{
    public class ProductSupplierRepository : GenericRepository<ProductSupplier>, IProductSupplierRepository
    {
        public ProductSupplierRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<ProductSupplier>> GetProductSupplierWithProductAndSupplier()
        {
            List<ProductSupplier> productSuppliersWithProductAndSupplier = await GetActivesAsIQueryable()
                .Include(x => x.Product)
                .Include(x => x.Supplier)
                .ToListAsync();
            return productSuppliersWithProductAndSupplier;
        }
    }
}