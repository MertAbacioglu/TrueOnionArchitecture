using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Abstarct;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class ProductSupplier : BaseEntity, IEntity
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public int MaxCountPerShipping { get; set; }

        //Relational Properties
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}
