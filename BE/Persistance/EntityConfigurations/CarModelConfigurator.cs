using Bogus;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal sealed class CarModelConfigurator : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.Property(c => c.Manufacturer)
             .HasMaxLength(50)
             .IsRequired();

            builder.Property(c => c.Model)
             .HasMaxLength(50)
             .IsRequired();

            builder.Property(c => c.Color)
             .HasMaxLength(50)
             .IsRequired();

            builder.Property(c => c.Year)
             .HasMaxLength(50)
             .IsRequired();

            builder.Property(c => c.CarGear)
             .HasMaxLength(50)
             .IsRequired();

            builder.HasData(GetCarModels());
        }

        private IReadOnlyCollection<CarModel> GetCarModels()
        {
            var id = 1;
            var currentTime = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var createdBy = "System Seeding";
            var colors = new[] { "red", "green", "blue", "yellow", "purple" };
            var random = new Random(42);

            var carModels = new CarModel[]
            {
                new CarModel
                {
                    Manufacturer = "Dacia",
                    Model = "Sandero",
                    CarGear = CarGear.Manual
                },
                new CarModel
                {
                    Manufacturer = "Skoda",
                    Model = "Fabia",
                    CarGear = CarGear.Manual
                },
                new CarModel
                {
                    Manufacturer = "Renault",
                    Model = "Zoe",
                    CarGear = CarGear.Automatic
                },
                new CarModel
                {
                    Manufacturer = "Skoda",
                    Model = "Fabia",
                    CarGear = CarGear.Automatic
                }
            };


            var carFaker = new Faker<CarModel>()
                .RuleFor(c => c.CreatedAt, _ => currentTime)
                .RuleFor(c => c.CreatedBy, _ => createdBy)
                .RuleFor(c => c.Year, f => f.Date.Between(DateTime.Now.AddYears(-5), DateTime.Now.AddYears(-2)))
                .RuleFor(c => c.Color, f => f.PickRandom(colors))
                .RuleFor(c => c.Manufacturer, _ => carModels[id - 1].Manufacturer)
                .RuleFor(c => c.Model, _ => carModels[id - 1].Model)
                .RuleFor(c => c.CarGear, _ => carModels[id - 1].CarGear)
                .RuleFor(c => c.Id, _ => id++);

            var cars = carFaker.Generate(carModels.Length);
            return cars;
        }
    }
}
