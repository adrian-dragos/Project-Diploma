using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal class InstructorConfigurator : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(i => i.Location)
             .HasMaxLength(150)
             .IsRequired();

            builder.HasData(GetInstructors());
        }

        private IReadOnlyCollection<Instructor> GetInstructors()
        {
            var now = DateTime.UtcNow;
            var createdBy = "System Seeding";

            var instructors = new List<Instructor>()
            {
                new Instructor
                {
                    Id = 1,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 1,
                    GearType = CarGear.Manual,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 2,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 8,
                    GearType = CarGear.Automatic,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 3,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 19,
                    GearType = CarGear.Automatic,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 4,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 23,
                    GearType = CarGear.Manual,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 5,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 24,
                    GearType = CarGear.Manual,
                    Location = "Strada Crișul 7"
                }
            };
            return instructors;
        }
    }
}
