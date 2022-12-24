using Microsoft.EntityFrameworkCore;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.PERSISTINCE.Seeds
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(FakeDataGenerator.Categories);
            modelBuilder.Entity<Product>().HasData(FakeDataGenerator.Products);
            modelBuilder.Entity<ProductFeature>().HasData(FakeDataGenerator.ProductFeatures);
            modelBuilder.Entity<Supplier>().HasData(FakeDataGenerator.Suppliers);
            modelBuilder.Entity<ProductSupplier>().HasData(FakeDataGenerator.ProductSuppliers);
        }
    }
}