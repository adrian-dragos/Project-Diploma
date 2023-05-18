using Domain.Entities.Common;

namespace Domain.Entities
{
    public sealed class Student : BaseEntity
    {
        public int IdentityId { get; set; }
        public Identity Identity { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }
    }

}
