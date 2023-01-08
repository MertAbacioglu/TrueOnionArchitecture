using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Account;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Repositories
{
    public interface IAppUserRepository : IGenericRepository<AppUser>
    {
        public Task<List<AppUser>> GetAllAppUsersWithRoles();
        public  Task<AppUser> GetAppUserWithRoles(int id);

    }
}
