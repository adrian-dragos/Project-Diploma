using Domain.Entities.Common;


namespace Domain.Entities.Authorization
{
    public sealed class Policy : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<PolicyRole> PolicyRoles { get; set; }
    }
}
