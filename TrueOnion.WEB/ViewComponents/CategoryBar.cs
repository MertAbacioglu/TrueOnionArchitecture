using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Services;

namespace TrueOnion.WEB.ViewComponents
{
    public class CategoryBar:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryBar(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _categoryService.GetCategoriesWithChildren());
        }
    }
}
