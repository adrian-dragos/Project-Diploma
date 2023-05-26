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
                    IdentityId = 4,
                    GearType = CarGear.Manual,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 3,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 7,
                    GearType = CarGear.Manual,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 4,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 8,
                    GearType = CarGear.Manual,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 5,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 10,
                    GearType = CarGear.Manual,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 6,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 13,
                    GearType = CarGear.Automatic,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 7,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 24,
                    GearType = CarGear.Automatic,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 8,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 25,
                    GearType = CarGear.Automatic,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 9,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 26,
                    GearType = CarGear.Automatic,
                    Location = "Strada Crișul 7"
                },
                new Instructor
                {
                    Id = 10,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 28,
                    GearType = CarGear.Automatic,
                    Location = "Strada Crișul 7"
                }
            };
            return instructors;
        }
    }
}
