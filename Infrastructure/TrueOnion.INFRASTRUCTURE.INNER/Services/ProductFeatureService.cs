using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.ProductFeature;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.INFRASTRUCTURE.INNER
{
    public class ProductFeatureService : GenericService<ProductFeatureSaveVM, ProductFeatureVM, ProductFeature>, IProductFeatureService
    {
        public ProductFeatureService(IGenericRepository<ProductFeature> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
