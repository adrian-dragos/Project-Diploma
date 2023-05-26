using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal sealed class CarConfigurator : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.RegistrationNumber)
             .HasMaxLength(50)
             .IsRequired();

           builder.Property(c => c.Vin)
             .HasMaxLength(20)
             .IsRequired();

            builder.HasData(GetCars(10));
        }

        private IReadOnlyCollection<Car> GetCars(int amount)
        {
            var id = 1;
            var currentTime = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var createdBy = "System Seeding";
            var random = new Random(42);

            var carFaker = new Faker<Car>()
                .RuleFor(c => c.Id, _ => id++)
                .RuleFor(c => c.CreatedAt, _ => currentTime)
                .RuleFor(c => c.CreatedBy, _ => createdBy)
                .RuleFor(c => c.CarModelId, _ => random.Next(1, 5))
                .RuleFor(c => c.Vin, f => f.Vehicle.Vin())
                .RuleFor(c => c.RegistrationNumber, f => f.Random.Replace("TM ### ???"));

            var cars = carFaker.Generate(amount);
            return cars;
        }
    }
}
