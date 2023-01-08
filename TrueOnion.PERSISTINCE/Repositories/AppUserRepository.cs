using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.ViewModels.Account;
using TrueOnion.APPLICATION.ViewModels.AppUser;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.DOMAIN.Enums;
using TrueOnion.PERSISTINCE.Context;

namespace TrueOnion.PERSISTINCE.Repositories
{
    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {

        public AppUserRepository(AppDbContext appDbContext, UserManager<AppUser> userManager) : base(appDbContext)
        {
        }

        //get all appusers with roles and return List<AppUser>
        public async Task<List<AppUser>> GetAllAppUsersWithRoles()
        {
            return await GetActivesAsIQueryable()                                                   
                                                .Include(x => x.UserRoles)
                                                .ThenInclude(x => x.Role)
                                                .ToListAsync();
             
        }

        //get app user with roles and return AppUser
        public async Task<AppUser> GetAppUserWithRoles(int id)
        {
            AppUser? appUser = await GetActivesAsIQueryable()
                                     .Include(x => x.UserRoles)
                                     .ThenInclude(x => x.Role)
                                     .FirstOrDefaultAsync(x => x.Id == id);
            return appUser;
        }


    }
}
