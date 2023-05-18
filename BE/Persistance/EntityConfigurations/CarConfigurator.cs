using Bogus;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal sealed class CarConfigurator : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(u => u.Manufacturer)
             .HasMaxLength(50)
             .IsRequired();

            builder.Property(u => u.Model)
             .HasMaxLength(50)
             .IsRequired();

            builder.Property(u => u.Color)
             .HasMaxLength(50)
             .IsRequired();

            builder.Property(u => u.RegistrationNumber)
             .HasMaxLength(50)
             .IsRequired();

            builder.Property(u => u.Year)
             .HasMaxLength(50)
             .IsRequired();

            builder.Property(u => u.CarGear)
             .HasMaxLength(50)
             .IsRequired();


            builder.HasData(this.GetCars(10));
        }

        private IReadOnlyCollection<Car> GetCars(int amount)
        {
            var id = 1;
            var currentTime = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var createdBy = "System Seeding";
            var colors = new[] { "red", "green", "blue", "yellow", "purple" };
            var allowedGears = new[] { CarGear.Automatic, CarGear.Manual };


            var carFaker = new Faker<Car>()
                .RuleFor(c => c.Id, _ => id++)
                .RuleFor(c => c.CreatedAt, _ => currentTime)
                .RuleFor(c => c.CreatedBy, _ => createdBy)
                .RuleFor(c => c.Manufacturer, f => f.Vehicle.Manufacturer())
                .RuleFor(c => c.Model, f => f.Vehicle.Model())
                .RuleFor(c => c.Year, f => f.Date.Between(DateTime.Now.AddYears(-5), DateTime.Now.AddYears(-2)))
                .RuleFor(c => c.Vin, f => f.Vehicle.Vin())
                .RuleFor(c => c.RegistrationNumber, f => f.Random.Replace("TM ### ???"))
                .RuleFor(c => c.Color, f => f.PickRandom(colors))
                .RuleFor(c => c.CarGear, f => f.PickRandom(allowedGears));

            var cars = carFaker.Generate(amount);
            return cars;
        }
    }
}
