namespace Domain.Entities.Authorization
{
    public sealed class PolicyRole : BaseEntity
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int PolicyId { get; set; }
        public Policy Policy { get; set; }

    }
}
