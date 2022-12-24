using System;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        //Relational Properties
        public ICollection<Product> Products { get; set; }
    }
}