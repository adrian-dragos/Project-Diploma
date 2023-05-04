using Domain;
using Domain.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfigurations
{
    internal class PolicyConfigurator : IEntityTypeConfiguration<Policy>
    {
        public void Configure(EntityTypeBuilder<Policy> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(p => p.Name)
                .IsUnique();

            builder.HasData(GetPolicies());
        }

        private IReadOnlyCollection<Policy> GetPolicies()
        {
            var now = DateTimeOffset.Now;
            var createdBy = "System Migration";

            var defaultRoles = new List<Policy>()
            {
                new Policy()
                {
                    Id = 1,
                    Name = "SeeAllUsers",
                    CreatedAt = now,
                    CreatedBy = createdBy
                },
                new Policy()
                {
                    Id = 2,
                    Name = "UpdateInstructorProfile",
                    CreatedAt = now,
                    CreatedBy = createdBy
                },
                new Policy()
                {
                    Id = 3,
                    Name = "UpdateUserProfile",
                    CreatedAt = now,
                    CreatedBy = createdBy
                }
            };
            return defaultRoles;
        }
    }
}
