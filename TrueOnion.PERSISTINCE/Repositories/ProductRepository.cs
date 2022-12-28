using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.DOMAIN.Enums;
using TrueOnion.PERSISTINCE.Context;

namespace TrueOnion.PERSISTINCE.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<Product> GetProduct(int id)
        {
            Product? product = await GetActivesAsIQueryable()
                .Include(x => x.Category)
                .Include(x => x.ProductFeature)
                .Include(x => x.ProductSuppliers)
                    .ThenInclude(x => x.Supplier)
                .FirstOrDefaultAsync(x=>x.ID==id);

            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            List<Product> products = await GetActivesAsIQueryable()
                .Include(x=>x.Category)
                .Where(x => x.Category.Status != DataStatus.Deleted)
                .Include(x=>x.ProductFeature)
                .Include(x=>x.ProductSuppliers)
                    .ThenInclude(x => x.Supplier)
                .ToListAsync();

            return products;
        }

        public async Task<IEnumerable<Product>> GetProductsByCount(int count)
        {
            List<Product> products = await GetActivesAsIQueryable()
                .Include(x => x.Category)
                .Where(x => x.Category.Status != DataStatus.Deleted)
                .Include(x => x.ProductFeature)
                .Include(x => x.ProductSuppliers)
                    .ThenInclude(x => x.Supplier)
                .OrderByDescending(x=>x.InsertedDate)
                .Take(count)
                .ToListAsync();

            return products;
        }

        
    }
}