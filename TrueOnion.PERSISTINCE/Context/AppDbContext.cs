using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.PERSISTINCE.Seeds;

namespace TrueOnion.PERSISTINCE.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole,int,AppUserClaim,AppUserRole, AppUserLogin,AppRoleClaim,AppUserToken>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ProductSupplier> ProductsSuppliers { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

    }
}
