using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.DOMAIN.Entities.Concrates
{
    public class AppUserClaim : IdentityUserClaim<int>
    {
        public AppUserClaim()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int Id { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
