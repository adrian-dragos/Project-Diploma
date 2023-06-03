using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal sealed class InstructorCarConfigurator : IEntityTypeConfiguration<InstructorCar>
    {
        public void Configure(EntityTypeBuilder<InstructorCar> builder)
        {
            builder.HasKey(ic => new { ic.InstructorId, ic.CarId });

            builder.HasOne(bc => bc.Instructor)
                .WithMany(b => b.InstructorCars)
                .HasForeignKey(bc => bc.InstructorId);

            builder.HasOne(bc => bc.Car)
                .WithMany(c => c.InstructorCars)
                .HasForeignKey(bc => bc.CarId);

            builder.HasData(GetInstructorCars());
        }

        private IReadOnlyCollection<InstructorCar> GetInstructorCars()
        {
            var createdAt = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var createdBy = "System Migration";

            var instructorCarList = new List<InstructorCar>()
            {
                new InstructorCar()
                {
                    Id = 1,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 1,
                    CarId = 2
                },
                new InstructorCar()
                {
                    Id = 2,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 1,
                    CarId = 6
                },
                new InstructorCar()
                {
                    Id = 3,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 2,
                    CarId = 3
                },
                new InstructorCar()
                {
                    Id = 4,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 3,
                    CarId = 5
                },
                new InstructorCar()
                {
                    Id = 5,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 4,
                    CarId = 6
                },
                new InstructorCar()
                {
                    Id = 6,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 5,
                    CarId = 9
                },                
                new InstructorCar()
                {
                    Id = 7,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 20,
                    CarId = 1
                },
                new InstructorCar()
                {
                    Id = 8,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 21,
                    CarId = 4
                },
                new InstructorCar()
                {
                    Id = 9,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 22,
                    CarId = 7
                },
                new InstructorCar()
                {
                    Id = 10,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 23,
                    CarId = 8
                },
                new InstructorCar()
                {
                    Id = 10,
                    CreatedAt = createdAt,
                    CreatedBy = createdBy,
                    InstructorId = 24,
                    CarId = 10
                },
            };
            return instructorCarList;
        }

    }
}
