using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.PERSISTINCE.Configurations
{
    public class ProductSupplierConfiguration : BaseConfiguration<ProductSupplier>
    {
        public override void Configure(EntityTypeBuilder<ProductSupplier> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x =>new
            {
                x.ProductID,
                x.SupplierID
            });
        }
    }
}
