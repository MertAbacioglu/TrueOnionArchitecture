using System.ComponentModel;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.ProductFeature;
using TrueOnion.APPLICATION.ViewModels.Supplier;

namespace TrueOnion.APPLICATION.ViewModels.Product
{
    public class ProductSaveVM : SaveVM,IBaseVM
    {
        public ProductSaveVM()
        {
            SupplierVMs = new List<SupplierVM>();
        }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        public List<int> SupplierIDs { get; set; }
        public List<CategoryVM>? CategoryVMs { get; set; }
        public List<SupplierVM>? SupplierVMs { get; set; }
        public ProductFeatureSaveVM? ProductFeatureSaveVM { get; set; }

    }
}