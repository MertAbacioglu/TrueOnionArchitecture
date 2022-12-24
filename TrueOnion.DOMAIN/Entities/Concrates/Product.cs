using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }

        //Relational Properties
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
        public ICollection<ProductSupplier> ProductSuppliers { get; set; }
    }
}