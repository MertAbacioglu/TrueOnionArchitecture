using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using TrueOnion.INFRASTRUCTURE.INNER;
using TrueOnion.APPLICATION.ViewModels.AppUser;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.Account;

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
            if (TempData["shortMessage"] != null)
                ViewBag.Message = TempData["shortMessage"].ToString();

            if (HttpContext.User?.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }

            return View();
        }
        //create index post action
        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginVM viewModel)
        {
            Result<AppUserSaveVM> result = await _appUserService.LoginAsync(viewModel);
            if (result.Data == null)
            {
                ViewBag.Message = result.Message;
                return View();
            }
            return RedirectToAction("Index", "Home", new { area = "Admin" });

        }
        public IActionResult Register()
        {
            return View(nameof(Register));
        }

        [HttpPost]
        public async Task<IActionResult> Register(AppUserSaveVM viewModel)
        {
            StringValues origin = Request.Headers["origin"];

            TempData["shortMessage"] = (await _appUserService.RegisterBasicUserAsync(viewModel, origin)).Message;
            return RedirectToAction(nameof(Login));
        }
        public IActionResult AccessDenied()
        {
            return View(nameof(AccessDenied));
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
