using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.ViewModels.ResultTypeViewModels;

namespace TrueOnion.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
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
