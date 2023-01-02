using System;
using System.ComponentModel.DataAnnotations.Schema;
using TrueOnion.DOMAIN.Entities.Abstarct;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class Category : BaseEntity, IEntity
    {
        public string CategoryName { get; set; }
        public int? ParentID { get; set; }

        //Relational Properties
        public ICollection<Product> Products { get; set; }
        public  Category? Parent { get; set; }

        public  ICollection<Category> Children { get; set; }

    }
}