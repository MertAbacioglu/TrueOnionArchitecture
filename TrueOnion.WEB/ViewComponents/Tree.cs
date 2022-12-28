using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Services;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.WEB.ViewComponents
{
    public class Tree : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public Tree(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<int> aaaa = new();
            aaaa.Add(id);
            return View(aaaa);
        }
    }
}
