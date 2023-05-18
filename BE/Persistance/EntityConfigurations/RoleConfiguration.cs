using Domain;
using Domain.Entities.Authorization;
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
            var now = DateTimeOffset.Now;
            var createdBy = "System Migration";

            var defaultRoles = new List<Role>()
            {
                new Role()
                {
                    Id = 1,
                    Name = DefaultRoles.Administrator,
                    CreatedAt = now,
                    CreatedBy = createdBy
                },
                new Role()
                {
                    Id = 2,
                    Name = DefaultRoles.Student,
                    CreatedAt = now,
                    CreatedBy = createdBy
                },
                new Role()
                {
                    Id = 3,
                    Name = DefaultRoles.Insturctor,
                    CreatedAt = now,
                    CreatedBy = createdBy
                }
            };
            return defaultRoles;
        }
    }
}
