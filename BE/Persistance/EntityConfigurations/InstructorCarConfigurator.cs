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
                    CarId = 1
                },
                new InstructorCar()
                {
                    Id = 2,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 1,
                    CarId = 2
                },
                new InstructorCar()
                {
                    Id = 3,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    InstructorId = 2,
                    CarId = 1
                }
            };
            return instructorCarList;
        }

    }
}
