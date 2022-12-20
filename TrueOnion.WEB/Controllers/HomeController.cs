using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.ResultTypeViewModels;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities;
using TrueOnion.PERSISTINCE.Repositories;
using TrueOnion.WEB.Filters;

namespace TrueOnion.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

     
        public HomeController(ILogger<HomeController> logger, IProductService productService,
            ICategoryService categoryService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
        }


        public async Task<IActionResult> Index()
        {
            Result<List<ProductVM>> productVMs = await _productService.GetProductsWithCategory();
            ProductListVM productListVM = new() { Response = productVMs };
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
        public async Task<IActionResult> GetProduct(int id)
        {
            Result<ProductSaveVM> productVM = await _productService.FindAsync(id);
            return View(productVM.Data);
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