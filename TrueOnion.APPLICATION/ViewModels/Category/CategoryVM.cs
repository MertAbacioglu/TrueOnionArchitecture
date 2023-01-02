using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.APPLICATION.ViewModels.Category
{
    public class CategoryVM :IBaseVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<ProductVM> ProductVMs { get; set; }
        public List<CategoryVM> Childreen { get; set; }
        public int ParentId { get; set; }
    }
}