using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.PERSISTINCE.Configurations
{
    public class ProductFeatureConfiguration : BaseConfiguration<ProductFeature>
    {
        public override void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
        }

    }
}
