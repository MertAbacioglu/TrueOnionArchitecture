using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.ProductSupplier;
using TrueOnion.APPLICATION.ViewModels.Supplier;

namespace TrueOnion.WEB.Helpers
{
    public static class JunctionTableHelper
    {
        public static List<ProductSupplierVM> ReplaceWithExist(List<SupplierVM> supplierVMs, ProductSaveVM productSaveVM)
        {
            List<ProductSupplierVM> allProductSupplierVMs = new();
            allProductSupplierVMs.AddRange(supplierVMs.Select(
                x => new ProductSupplierVM
                {
                    SupplierId = x.Id,
                    SupplierVM = new SupplierVM
                    {
                        Id = x.Id,
                        CompanyName = x.CompanyName
                    }
                }));
            List<ProductSupplierVM> toBeRemoved = allProductSupplierVMs.Where(x => productSaveVM.ProductSupplierVMs
                                                                       .Any(y => y.SupplierId == x.SupplierId))
                                                                       .ToList();
            toBeRemoved.ForEach(x => allProductSupplierVMs.Remove(x));
            productSaveVM.ProductSupplierVMs.ForEach(x => x.isSelected = true);
            allProductSupplierVMs.AddRange(productSaveVM.ProductSupplierVMs);            
            return allProductSupplierVMs.OrderByDescending(x => x.isSelected).ToList();
        }
    }
}
