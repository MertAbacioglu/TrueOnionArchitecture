using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities;

namespace TrueOnion.PERSISTINCE.Configurations
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
         public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

        }
    }
}
