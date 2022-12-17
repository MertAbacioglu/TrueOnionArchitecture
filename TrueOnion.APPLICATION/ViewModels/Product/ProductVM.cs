using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.APPLICATION.ViewModels.Product
{
    public class ProductVM : IBaseVM
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public CategoryVM CategoryVM { get; set; }
    }
}