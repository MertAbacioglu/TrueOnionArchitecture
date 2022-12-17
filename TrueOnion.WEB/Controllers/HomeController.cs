using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.ViewModels.ResultTypeViewModels;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities;
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

        [HttpPost]
        public async Task<IActionResult> Add(ProductSaveVM viewModel)
        {
            await _productService.AddAsync(viewModel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Add()
        {
            List<CategoryVM>? categoryVMs = (await _categoryService.GetActives()).Data;
            return View(new ProductSaveVM() { CategoryVMs = categoryVMs});
        }

        public IActionResult Privacy()
        {
            return View();
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
            
            Result<ProductSaveVM> productVM = await _productService.FindAsync(id);
            return View(productVM.Data);
        }
        [HttpPost]
        public  async Task<IActionResult> Update(ProductVM viewModel)
        {
            await _productService.UpdateAsync(viewModel);
            return RedirectToAction("Index");
        }
    }
}