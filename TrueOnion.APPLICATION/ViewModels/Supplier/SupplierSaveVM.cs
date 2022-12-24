using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;

namespace TrueOnion.APPLICATION.ViewModels.Supplier
{
    public class SupplierSaveVM : SaveVM
    {
        public string CompanyName { get; set; }
    }
}
