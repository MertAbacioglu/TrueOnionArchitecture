
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.DOMAIN.Entities.Common
{
    public abstract class BaseEntity
    {
        public BaseEntity()
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