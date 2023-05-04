using Domain.Entities.Common;


namespace Domain.Entities.Authorization
{
    public class Policy : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<PolicyRole> PolicyRoles { get; set; }
    }
}
