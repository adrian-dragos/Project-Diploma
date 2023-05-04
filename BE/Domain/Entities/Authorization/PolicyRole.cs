using Domain.Entities.Common;

namespace Domain.Entities.Authorization
{
    public class PolicyRole : BaseEntity
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int PolicyId { get; set; }
        public Policy Policy { get; set; }

    }
}
