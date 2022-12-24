using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;

namespace TrueOnion.APPLICATION.ViewModels.Supplier
{
    public class ProductFeatureVM :IBaseVM
    {
        public int ID { get; set; }
        public DateTime RealeseDate { get; set; }
        public string MadeIn { get; set; }

    }
}
