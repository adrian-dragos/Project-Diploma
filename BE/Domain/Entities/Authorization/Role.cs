using Domain.Entities.Common;

namespace Domain.Entities.Authorization
{
    public sealed class Role : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<PolicyRole> PolicyRoles { get; set; }
        public IEnumerable<Identity> Users { get; set; }
    }
}
