using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;

namespace TrueOnion.APPLICATION.ViewModels.ProductSupplier
{
    public class ProductSupplierSaveVM : SaveVM
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int MaxCountPerShipping { get; set; }
    }
}