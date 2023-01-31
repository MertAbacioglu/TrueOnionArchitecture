using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.ProductSupplier;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.INFRASTRUCTURE.INNER.Services
{
    public class ProductSupplierService : GenericService<ProductSupplierSaveVM, ProductSupplierVM, ProductSupplier>, IProductSupplierService
    { private readonly IProductSupplierRepository _productSupplierRepository;
        public ProductSupplierService(IGenericRepository<ProductSupplier> repository, IMapper mapper, IProductSupplierRepository productSupplierRepository) : base(repository, mapper)
        {
            _productSupplierRepository = productSupplierRepository;
        }

        public async Task<Result<List<ProductSupplierVM>>> GetProductSupplierWithProductAndSupplier()
        {

            List<ProductSupplier> result = (await _productSupplierRepository.GetProductSupplierWithProductAndSupplier()).ToList();
            List<ProductSupplierVM> productSupplierVMs = _mapper.Map<List<ProductSupplierVM>>(result);
            return Result<List<ProductSupplierVM>>.Success(productSupplierVMs);
            
    }
    }
}
