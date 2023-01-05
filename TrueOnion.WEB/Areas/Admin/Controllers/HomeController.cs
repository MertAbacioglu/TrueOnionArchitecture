using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.ViewModels.ResultTypeViewModels;

namespace TrueOnion.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error(ErrorVM errorViewModel)
        {
            return View(errorViewModel);
        }
    }
}
