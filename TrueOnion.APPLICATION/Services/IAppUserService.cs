using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Account;
using TrueOnion.APPLICATION.ViewModels.AppUser;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Services
{
    public interface IAppUserService 
    {
        public Task<Result<AppUserSaveVM>> RegisterBasicUserAsync(AppUserSaveVM viewModel, string origin);
        public Task<string> ConfirmEmailAsync(string userId, string token);
        public Task<bool> LoginAsync(LoginVM vm);
    }
}
