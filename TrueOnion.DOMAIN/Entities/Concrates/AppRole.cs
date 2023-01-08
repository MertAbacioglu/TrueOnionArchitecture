using Microsoft.AspNetCore.Identity;
using TrueOnion.DOMAIN.Entities.Abstarct;
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class AppRole : IdentityRole<int>,IEntity
    {
        public AppRole()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public DateTime? InsertedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relational Properties
        public  ICollection<AppUserRole> UserRoles { get; set; }

    }
}