using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal class StudentConfigurator : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(GetStudents());
        }

        private IReadOnlyCollection<Student> GetStudents()
        {
            var createdAt = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var createdBy = "System Seeding";

            var students = new List<Student>();
            int[] studentRoleIds = { 2, 3, 5, 6, 9, 11, 12, 14, 15, 16, 18, 21, 22, 23, 27, 29, 33, 34, 35, 38, 42, 43, 44, 45, 48, 49 };
            var carGear = CarGear.Manual;
            var switchGearSeedingIndex = studentRoleIds.Length / 2;

            for (int i = 0; i < studentRoleIds.Length; i++)
            {
                students.Add(new Student
                {
                    Id = i + 1,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    IdentityId = studentRoleIds[i],
                    GearType = carGear
                });

                var switchToAutomaticGearSeeding = i == switchGearSeedingIndex;
                if (switchToAutomaticGearSeeding)
                {
                    carGear = CarGear.Automatic;
                }
            }

            return students;
        }
    }
}
