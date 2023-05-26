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
            var now = DateTimeOffset.Now;
            var createdBy = "System Migration";

            var instructorCarList = new List<InstructorCar>()
            {
                new InstructorCar()
                {
                    Id = 1,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 1,
                    CarId = 2
                },
                new InstructorCar()
                {
                    Id = 2,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 1,
                    CarId = 6
                },
                new InstructorCar()
                {
                    Id = 3,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 2,
                    CarId = 3
                },
                new InstructorCar()
                {
                    Id = 4,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 3,
                    CarId = 5
                },
                new InstructorCar()
                {
                    Id = 5,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 4,
                    CarId = 6
                },
                new InstructorCar()
                {
                    Id = 6,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 5,
                    CarId = 9
                },                
                new InstructorCar()
                {
                    Id = 7,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 6,
                    CarId = 1
                },
                new InstructorCar()
                {
                    Id = 8,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 7,
                    CarId = 4
                },
                new InstructorCar()
                {
                    Id = 9,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 8,
                    CarId = 7
                },
                new InstructorCar()
                {
                    Id = 10,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 9,
                    CarId = 8
                },
                new InstructorCar()
                {
                    Id = 10,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 10,
                    CarId = 10
                },
            };
            return instructorCarList;
        }

    }
}
