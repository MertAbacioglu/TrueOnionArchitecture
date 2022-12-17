using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TrueOnion.DOMAIN.Entities;
using TrueOnion.PERSISTINCE.Configurations;
using TrueOnion.PERSISTINCE.Seeds;

namespace TrueOnion.PERSISTINCE.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

    }
}
