using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.AppUser;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.WEB.Areas.Admin.ViewComponents
{
    public class UserMenuViewComponent : ViewComponent
    {
        private readonly IAppUserService _appUserService;


        public UserMenuViewComponent(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUserVM? appUserVM = (await _appUserService.GetUserAsync()).Data;
            return View(appUserVM);
        }
    }
}
