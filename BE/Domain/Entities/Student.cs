using Domain.Entities.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public sealed class Student : BaseEntity
    {
        public int IdentityId { get; set; }
        public Identity Identity { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }
        public CarGear GearType { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }

}
