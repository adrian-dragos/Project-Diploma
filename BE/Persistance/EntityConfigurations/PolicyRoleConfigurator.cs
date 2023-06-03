using Domain.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal class PolicyRoleConfigurator : IEntityTypeConfiguration<PolicyRole>
    {
        public void Configure(EntityTypeBuilder<PolicyRole> builder)
        {
            builder.HasKey(bc => new { bc.RoleId, bc.PolicyId });

            builder.HasOne(bc => bc.Role)
                .WithMany(b => b.PolicyRoles)
                .HasForeignKey(bc => bc.RoleId);

            builder.HasOne(bc => bc.Policy)
                .WithMany(c => c.PolicyRoles)
                .HasForeignKey(bc => bc.PolicyId);

            builder.HasData(GetPolicyRole());
        }

        private IReadOnlyCollection<PolicyRole> GetPolicyRole()
        {
            var craeatedAt = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var createdBy = "System Migration";

            var policyRoles = new List<PolicyRole>()
            {
                new PolicyRole()
                {
                    Id = 1,
                    RoleId = 1,
                    PolicyId = 1,
                    CreatedAt = craeatedAt,
                    CreatedBy = createdBy
                },
                new PolicyRole()
                {
                    Id = 2,
                    RoleId = 1,
                    PolicyId = 2,
                    CreatedAt = craeatedAt,
                    CreatedBy = createdBy
                },
                new PolicyRole()
                {
                    Id = 3,
                    RoleId = 2,
                    PolicyId = 2,
                    CreatedAt = craeatedAt,
                    CreatedBy = createdBy
                },
                new PolicyRole()
                {
                    Id = 4,
                    RoleId = 3,
                    PolicyId = 3,
                    CreatedAt = craeatedAt,
                    CreatedBy = createdBy
                }
            };
            return policyRoles;
        }
    }
}
