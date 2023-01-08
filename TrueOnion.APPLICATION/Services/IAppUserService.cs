using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Account;
using TrueOnion.APPLICATION.ViewModels.AppRole;
using TrueOnion.APPLICATION.ViewModels.AppUser;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Services
{
    public interface IAppUserService 
    {
        public Task<Result<AppUserSaveVM>> RegisterBasicUserAsync(AppUserSaveVM viewModel, string origin);
        public Task<string> ConfirmEmailAsync(string userId, string token);
        public Task<Result<AppUserSaveVM>> LoginAsync(AppUserLoginVM vm);
        public Task SignOutAsync();
        public Task<Result<AppUserVM>> GetUserAsync();
        public Task<Result<List<AppUserVM>>> GetAllAppUsersWithRoles();
        public Task<Result<AppUserVM>> GetAppUserWithRoles(int id);
        public Task<Result<List<AppRoleVM>>> GetAllRoles();
        public Task<Result<AppUserVM>> UpdateAppUserRole(AppUserVM viewModel);


    }
}
