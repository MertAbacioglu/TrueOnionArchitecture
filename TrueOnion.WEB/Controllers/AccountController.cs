using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Account;
using TrueOnion.APPLICATION.ViewModels.AppUser;

namespace TrueOnion.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAppUserService _appUserService;

        public AccountController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Login()
        {
            return View();
        }
        //create index post action
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM viewModel)
        {
            var result = await _appUserService.LoginAsync(viewModel);
            return RedirectToAction("Index", "Home", new { area = "Admin" });
        }
        public IActionResult Register()
        {
            return View(nameof(Register));
        }
        public IActionResult AccessDenied()
        {
            return View(nameof(AccessDenied));
        }

        [HttpPost]
        public async Task<IActionResult> Register(AppUserSaveVM viewModel)
        {
            var origin = Request.Headers["origin"];

            await _appUserService.RegisterBasicUserAsync(viewModel, origin);
            return RedirectToAction(nameof(ConfirmEmail));
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            string response = await _appUserService.ConfirmEmailAsync(userId, token);
            return View(nameof(ConfirmEmail), response);
        }

        //create sign out action
        public async Task<IActionResult> LogOut()
        {
            await _appUserService.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }


    }
}
