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
    public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<Supplier>> GetSuppliersWithProducts()
        {
            List<Supplier> suppliers = await GetActivesAsIQueryable()
                .Include(x => x.ProductSuppliers)
                    .ThenInclude(x => x.Product)
                .ToListAsync();
            return suppliers;

        }
    }
}
