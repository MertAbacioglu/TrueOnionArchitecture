using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Account;

namespace TrueOnion.APPLICATION.Services
{
    public interface IAccountService
    {
        Task<AppUserSaveVM> RegisterAsync(AppUserSaveVM viewModel);
    }
}
