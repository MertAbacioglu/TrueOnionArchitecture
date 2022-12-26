using TrueOnion.APPLICATION.ViewModels.ProductFeature;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Services
{
    public interface IProductFeatureService : IGenericService<ProductFeatureSaveVM,ProductFeatureVM,ProductFeature>
    {
    }
}
