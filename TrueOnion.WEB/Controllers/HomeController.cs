using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Account;
using TrueOnion.APPLICATION.ViewModels.AppUser;

namespace TrueOnion.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppUserService _appUserService;

        public HomeController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        public IActionResult Index()
        {
            return View();
        }
        //create index post action
        [HttpPost]
        public async Task<IActionResult> Index(LoginVM viewModel)
        {
            var result = await _appUserService.LoginAsync(viewModel);
            return RedirectToAction("Index", "Products", new { area = "Admin" });
        }
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(AppUserSaveVM viewModel)
        {
            var origin = Request.Headers["origin"];

            await _appUserService.RegisterBasicUserAsync(viewModel, origin);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            string response = await _appUserService.ConfirmEmailAsync(userId, token);
            return View(nameof(ConfirmEmail),response);
        }

       
    }
}