using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Abstarct;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class Supplier : BaseEntity, IEntity
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }

        //Relational Properties
        public ICollection<ProductSupplier> ProductSuppliers { get; set; }

    }
}