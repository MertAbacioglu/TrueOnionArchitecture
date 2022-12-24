using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.ProductSupplier;
using TrueOnion.APPLICATION.ViewModels.ResultTypeViewModels;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.WEB.Filters;

namespace TrueOnion.WEB.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ISupplierService _supplierService;
        private readonly IProductSupplierService _productSupplierService;
        private readonly IProductRepository _productRepository;


        public ProductsController(IProductService productService, ICategoryService categoryService, IProductSupplierService productSupplierService, IProductRepository productRepository, ISupplierService supplierService)

        {
            _productService = productService;
            _categoryService = categoryService;
            _productSupplierService = productSupplierService;
            _productRepository = productRepository;
            _supplierService = supplierService;
        }


        public async Task<IActionResult> Index()
        {
            //List<ProductSupplierVM>? a = (await _productSupplierService.GetProductSupplierWithProductAndSupplier()).Data;
            //IEnumerable<Product> aa = await _productRepository.GetProductsWithCategory();
            //List<SupplierVM>? ab = (await _supplierService.GetActives()).Data;





            Result<List<ProductVM>> productVMs = await _productService.GetProductsWithCategory();
            ProductListVM productListVM = new() { Result = productVMs };
            return View(productListVM);
        }

        
        public async Task<IActionResult> Add()
        {

            List<CategoryVM>? categoryVMs = (await _categoryService.GetActives()).Data;
            return View(new ProductSaveVM() { CategoryVMs = categoryVMs });
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductSaveVM viewModel)
        {
            await _productService.AddAsync(viewModel);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(ErrorVM errorVM)
        {
            return View(errorVM);
        }

        
        [ServiceFilter(typeof(NotFoundFilter<ProductSaveVM, ProductVM, Product>))]
        public async Task<IActionResult> Update(int id)
        {

            ProductSaveVM productSaveVM = (await _productService.FindAsync(id)).Data;
            List<CategoryVM>? categoryVMs = (await _categoryService.GetActives()).Data;
            productSaveVM.CategoryVMs = categoryVMs;



            return View(productSaveVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductSaveVM viewModel)
        {
            await _productService.UpdateAsync(viewModel);
            return RedirectToAction("Index");
        }

        [ServiceFilter(typeof(NotFoundFilter<ProductSaveVM, ProductVM, Product>))]
        public async Task<IActionResult> Remove(int id)
        {
            await _productService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}