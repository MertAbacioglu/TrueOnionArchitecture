using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.PERSISTINCE.Services
{
    public class SupplierService : GenericService<SupplierSaveVM, SupplierVM, Supplier>,ISupplierService
    {
        public SupplierService(IGenericRepository<Supplier> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
