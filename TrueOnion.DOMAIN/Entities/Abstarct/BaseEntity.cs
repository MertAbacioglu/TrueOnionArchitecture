
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.DOMAIN.Entities.Common
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            InsertedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

    }
}
