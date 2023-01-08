using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.ProductSupplier;

namespace TrueOnion.APPLICATION.ViewModels.Supplier
{
    public class SupplierVM : IBaseVM
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public List<ProductSupplierVM> ProductSupplierVMs { get; set; }

    }
}
