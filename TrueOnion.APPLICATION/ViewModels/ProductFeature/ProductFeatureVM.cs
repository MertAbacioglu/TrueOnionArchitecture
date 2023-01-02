using TrueOnion.APPLICATION.ViewModels.Abstracts;

namespace TrueOnion.APPLICATION.ViewModels.ProductFeature
{
    public class ProductFeatureVM :IBaseVM
    {
        public int Id { get; set; }
        public DateTime RealeseDate { get; set; }
        public string MadeIn { get; set; }

    }
}
