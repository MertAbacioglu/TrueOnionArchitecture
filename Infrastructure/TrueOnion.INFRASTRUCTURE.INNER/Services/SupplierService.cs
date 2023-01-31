using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.INFRASTRUCTURE.INNER
{
    public class SupplierService : GenericService<SupplierSaveVM, SupplierVM, Supplier>,ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        public SupplierService(IGenericRepository<Supplier> repository, IMapper mapper, ISupplierRepository supplierRepository) : base(repository, mapper)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<SupplierListVM> GetSuppliersWithProducts()
        {
            List<Supplier> suppliers = (await _supplierRepository.GetSuppliersWithProducts()).ToList();
            List<SupplierVM> supplierVMs = _mapper.Map<List<SupplierVM>>(suppliers);
            Result<List<SupplierVM>> result = Result<List<SupplierVM>>.Success(supplierVMs);
            return new SupplierListVM { Result = result };
        }
    }
}
