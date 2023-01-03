using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Abstarct;
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class AppUserRole : IdentityUserRole<int>,IEntity
    {
        public AppUserRole()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public DateTime? InsertedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DataStatus Status { get; set; }
        public int Id { get; set; }
    }
}


