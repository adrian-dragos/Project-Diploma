using Domain.Entities.Authorization;
using Domain.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(r => r.Name)
                .IsUnique();

            builder.HasData(GetRoles());
        }

        private IReadOnlyCollection<Role> GetRoles()
        {
            var createdAt = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var createdBy = "System Migration";

            var defaultRoles = new List<Role>()
            {
                new Role()
                {
                    Id = 1,
                    Name = DefaultRoles.Administrator,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy
                },
                new Role()
                {
                    Id = 2,
                    Name = DefaultRoles.Student,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy
                },
                new Role()
                {
                    Id = 3,
                    Name = DefaultRoles.Insturctor,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy
                }
            };
            return defaultRoles;
        }
    }
}
