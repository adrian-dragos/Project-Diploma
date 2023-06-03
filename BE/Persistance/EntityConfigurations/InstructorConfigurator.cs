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
            var time = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var createdBy = "System Seeding";

            var instructors = new List<Instructor>();
            int[] instructorRoleIds = { 1, 4, 7, 8, 10, 13, 17, 19, 20, 24, 25, 26, 28, 30, 31, 32, 36, 37, 39, 40, 41, 46, 47, 50 };
            string[] locations = { "Strada Crișul 7", "Ion Creanga 2" };
            var random = new Random(42);
            var carGear = CarGear.Manual;
            var switchGearSeedingIndex = instructorRoleIds.Length / 2;

            for (int i = 0; i < instructorRoleIds.Length; i++)
            {
                int randomIndex = random.Next(0, locations.Length);
                instructors.Add(new Instructor
                {
                    Id = i + 1,
                    CreatedAt = time,
                    CreatedBy = createdBy,
                    IdentityId = instructorRoleIds[i],
                    GearType = carGear,
                    Location = locations[randomIndex]
                });

                var switchToAutomaticGearSeeding = i == switchGearSeedingIndex;
                if (switchToAutomaticGearSeeding)
                {
                    carGear = CarGear.Automatic;
                }
            }
            return instructors;
        }
    }
}
