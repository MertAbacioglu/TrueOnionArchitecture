using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities;

namespace TrueOnion.PERSISTINCE.Seeds
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(FakeDataGenerator.Categories);
            modelBuilder.Entity<Product>().HasData(FakeDataGenerator.Products);
        }
    }
}
