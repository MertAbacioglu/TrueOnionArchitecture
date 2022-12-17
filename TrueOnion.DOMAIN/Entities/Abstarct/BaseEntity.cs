
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.DOMAIN.Entities.Common
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

    }
}
