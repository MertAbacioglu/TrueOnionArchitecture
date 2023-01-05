using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.ResultTypeViewModels;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.WEB.Filters;

namespace TrueOnion.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ISupplierService _supplierService;
        private readonly IProductSupplierService _productSupplierService;
        private readonly IProductRepository _productRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IProductSupplierRepository _productSupplierRepository;


        public ProductsController(IProductService productService, ICategoryService categoryService, IProductSupplierService productSupplierService, IProductRepository productRepository, ISupplierService supplierService, ISupplierRepository supplierRepository, IProductSupplierRepository productSupplierRepository)

        {
            _productService = productService;
            _categoryService = categoryService;
            _productSupplierService = productSupplierService;
            _productRepository = productRepository;
            _supplierService = supplierService;
            _supplierRepository = supplierRepository;
            _productSupplierRepository = productSupplierRepository;
        }

        public async Task<IActionResult> Index()
        {
            //await _categoryService.GetCategoryWithChildren(3);
            //await _categoryService.GetCategoriesWithChildren();
            return View(await _productService.GetProducts());
        }
        
        public async Task<IActionResult> Add()
        {

            List<CategoryVM>? categoryVMs = (await _categoryService.GetActives()).Data;
            List<SupplierVM>? supplierVMs = (await _supplierService.GetActives()).Data;
            return View(new ProductSaveVM() { CategoryVMs = categoryVMs, SupplierVMs = supplierVMs });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//todo : look
        public async Task<IActionResult> Add(ProductSaveVM viewModel)
        {
            await _productService.AddAsync(viewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Error(ErrorVM errorVM)
        {
            return View(errorVM);
        }


        [ServiceFilter(typeof(NotFoundFilter<ProductSaveVM, ProductVM, Product>))]
        public async Task<IActionResult> Update(int id)
        {

            ProductSaveVM productSaveVM = (await _productService.GetProduct(id)).Data;
            List<CategoryVM>? categoryVMs = (await _categoryService.GetActives()).Data;
            List<SupplierVM>? supplierVMs = (await _supplierService.GetActives()).Data;
            productSaveVM.CategoryVMs = categoryVMs;
            productSaveVM.SupplierVMs = supplierVMs;

            return View(productSaveVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductSaveVM viewModel)
        {
            await _productService.UpdateAsync(viewModel);
            return RedirectToAction(nameof(Index));
        }

        [ServiceFilter(typeof(NotFoundFilter<ProductSaveVM, ProductVM, Product>))]
        public async Task<IActionResult> Remove(int id)
        {
            await _productService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}