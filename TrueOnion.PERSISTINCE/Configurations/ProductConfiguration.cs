using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.PERSISTINCE.Configurations
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryID)
                .OnDelete(DeleteBehavior.Cascade);//default behavior is  already cascade

            builder
                .HasOne(x => x.ProductFeature)
                .WithOne(x => x.Product)
                .HasForeignKey<ProductFeature>(x => x.Id)
                .OnDelete(DeleteBehavior.Cascade);
            ;
        }
    }
}
