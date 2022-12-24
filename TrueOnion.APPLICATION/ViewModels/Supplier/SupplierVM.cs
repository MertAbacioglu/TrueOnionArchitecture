using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.ProductSupplier;

namespace TrueOnion.APPLICATION.ViewModels.Supplier
{
    public class SupplierVM : IBaseVM
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }

    }
}
