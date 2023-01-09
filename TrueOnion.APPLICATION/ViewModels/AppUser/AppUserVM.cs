using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.AppRole;
using TrueOnion.APPLICATION.ViewModels.AppUserRole;

namespace TrueOnion.APPLICATION.ViewModels.AppUser
{
    public class AppUserVM : IBaseVM
    {
        public AppUserVM()
        {
            AppUserRoleVMs = new List<AppUserRoleVM>();
            AppRoleVMs = new List<AppRoleVM>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public List<AppUserRoleVM> AppUserRoleVMs { get; set; }//roles of user
        public List<AppRoleVM> AppRoleVMs { get; set; } //all roles in database
        public bool isCurrentUser { get; set; }//has user updated  his own role
    }
}
