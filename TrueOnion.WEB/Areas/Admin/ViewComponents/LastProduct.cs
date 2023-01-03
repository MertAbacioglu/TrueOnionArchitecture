using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Services;

namespace TrueOnion.WEB.Areas.Admin.ViewComponents

{
    public class LastProduct : ViewComponent
    {
        private readonly IProductService _productService;

        public LastProduct(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            return View(await _productService.GetProductsByCount(count));
        }
    }
}