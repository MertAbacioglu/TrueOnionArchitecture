using TrueOnion.APPLICATION.Repositories;
using TrueOnion.APPLICATION.ViewModels.Account;
using TrueOnion.APPLICATION.Wrappers;
using TrueOnion.DOMAIN.Entities.Concrates;
using TrueOnion.PERSISTINCE.Context;

namespace TrueOnion.PERSISTINCE.Repositories
{
    public class AppUserRepository : GenericRepository<AppUser>,IAppUserRepository
    {


        public AppUserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }


    }
}
