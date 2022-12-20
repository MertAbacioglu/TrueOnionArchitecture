using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.DOMAIN.Entities;
using TrueOnion.PERSISTINCE.Context;

namespace TrueOnion.PERSISTINCE.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<Product>> GetProductsWithCategory()
        {
            List<Product> productsWithCategory = await GetActivesAsIQueryable()
                .Include(x=>x.Category)
                .AsNoTracking()
                .ToListAsync();

            return productsWithCategory;
        }
    }
}