using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.PERSISTINCE.Configurations
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryID);
            builder.HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x => x.ID);
        }
    }
}
