using System.ComponentModel;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.Category;

namespace TrueOnion.APPLICATION.ViewModels.Product
{
    public class ProductSaveVM : IBaseVM,ISaveVM
    {
        public int ID { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public List<CategoryVM>? CategoryVMs { get; set; }
    }
}