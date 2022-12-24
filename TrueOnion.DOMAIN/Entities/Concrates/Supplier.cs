using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class Supplier : BaseEntity
    {
        public string CompanyName { get; set; }

        //Relational Properties
        public ICollection<ProductSupplier> ProductSuppliers { get; set; }

    }
}
