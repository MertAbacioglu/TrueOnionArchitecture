using Microsoft.AspNetCore.Mvc;

namespace TrueOnion.WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
