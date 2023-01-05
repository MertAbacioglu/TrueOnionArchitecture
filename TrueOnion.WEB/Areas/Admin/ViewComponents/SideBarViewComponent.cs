using Microsoft.AspNetCore.Mvc;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.AppUser;

namespace TrueOnion.WEB.Areas.Admin.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly IAppUserService _appUserService;


        public SideBarViewComponent(IAppUserService appUserService)
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
