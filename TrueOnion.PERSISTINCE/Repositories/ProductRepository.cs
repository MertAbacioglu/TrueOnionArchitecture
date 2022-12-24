using Microsoft.EntityFrameworkCore;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.DOMAIN.Entities.Concrates;
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
                .Include(x=>x.ProductFeature)
                .Include(x=>x.ProductSuppliers)
                    .ThenInclude(x => x.Supplier)
                .ToListAsync();

            return productsWithCategory;
        }

        public async Task<IEnumerable<Product>> GetProductsByPriceRange(decimal min, decimal max)
        {
            List<Product> productsByPriceRange = GetActivesAsIQueryable()
                .Where(x => x.Price >= min && x.Price <= max)
                .Include(x => x.Category)
                .ToList();
            return productsByPriceRange;
        }
    }
}