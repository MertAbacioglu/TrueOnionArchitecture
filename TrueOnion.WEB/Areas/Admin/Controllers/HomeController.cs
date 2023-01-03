using Microsoft.AspNetCore.Mvc;

namespace TrueOnion.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
