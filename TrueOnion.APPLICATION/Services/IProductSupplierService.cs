using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.ProductSupplier;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Services
{
    public interface IProductSupplierService : IGenericService<ProductSupplierSaveVM,ProductSupplierVM,ProductSupplier>
    {
        public Task<Result<List<ProductSupplierVM>>> GetProductSupplierWithProductAndSupplier();

    }
}
