using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.Supplier;

namespace TrueOnion.APPLICATION.ViewModels.ProductSupplier
{
    public class ProductSupplierVM : IBaseVM
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public int MaxCountPerShipping { get; set; }

        public ProductVM ProductVM { get; set; }
        public SupplierVM SupplierVM { get; set; }

    }
}
