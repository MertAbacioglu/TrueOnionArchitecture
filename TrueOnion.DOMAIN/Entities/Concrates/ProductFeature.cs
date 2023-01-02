using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Abstarct;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class ProductFeature : BaseEntity, IEntity
    {
        public string MadeIn { get; set; }
        public DateTime RelaseDate { get; set; }

        //Relational Properties
        public Product Product { get; set; }
    }
}
