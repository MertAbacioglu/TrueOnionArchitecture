using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Services
{
    public interface ISupplierService : IGenericService<SupplierSaveVM, SupplierVM,Supplier>
    {
    }
}
