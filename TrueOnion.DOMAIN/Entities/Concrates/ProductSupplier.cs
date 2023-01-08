using TrueOnion.DOMAIN.Entities.Abstarct;
using TrueOnion.DOMAIN.Entities.Common;
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class ProductSupplier :  BaseEntity, IEntity
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        
        //Relational Properties
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}
