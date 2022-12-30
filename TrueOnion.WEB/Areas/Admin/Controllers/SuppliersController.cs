using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.PERSISTINCE.Services;
using TrueOnion.WEB.Filters;

namespace TrueOnion.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SuppliersController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _supplierService.GetSuppliersWithProducts());
        }

        [HttpPost]
        public async Task<IActionResult> Add(SupplierSaveVM supplierSaveVM)
        {
            await _supplierService.AddAsync(supplierSaveVM);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Add()
        {
            return View();
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _supplierService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [ServiceFilter(typeof(NotFoundFilter<ProductSaveVM, ProductVM, Product>))]
        public async Task<IActionResult> Update(int id)
        {

            return View((await _supplierService.FindAsync(id)).Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SupplierSaveVM viewModel)
        {
            await _supplierService.UpdateAsync(viewModel);
            return RedirectToAction(nameof(Index));
        }





    }
}
