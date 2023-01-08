using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Services;
using TrueOnion.APPLICATION.ViewModels.AppRole;
using TrueOnion.APPLICATION.ViewModels.AppUser;
using TrueOnion.APPLICATION.Wrappers;

namespace TrueOnion.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class RolesController : Controller
    {
        //di for IAppUserService
        private readonly IAppUserService _appUserService;


        public RolesController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public async Task<IActionResult> Index()
        {
            Result<List<AppUserVM>> usersWithRoles = await _appUserService.GetAllAppUsersWithRoles();

            return View(nameof(Index), new AppUserListVM { Result = usersWithRoles });
        }

        public async Task<IActionResult> Update(int id)
        {
            AppUserVM? userWithRoles = (await _appUserService.GetAppUserWithRoles(id)).Data;
            return View(nameof(Update), userWithRoles);
        }

        //create update post method
        [HttpPost]
        public async Task<IActionResult> Update(AppUserVM appUserVM)
        {
            await _appUserService.UpdateAppUserRole(appUserVM);
            return RedirectToAction(nameof(Index));
        }
    }
}
