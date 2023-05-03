using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsRequired(false); ;

            builder.Property(e => e.Email)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasIndex(e => e.Email)
                .IsUnique();

            builder.Property(e => e.Password)
                .HasMaxLength(255)
                .IsRequired();

            if (!builder.Metadata.GetProperties().Any(x => x.Name == "Id"))
            {
            }
            builder.HasData(GetUsers(10));
        }

        private IReadOnlyCollection<User> GetUsers(int amount)
        {
            var id = 1;
            var currentTime = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923);
            var createdBy = "System Seeding";

            var userFaker = new Faker<User>()
                .RuleFor(x => x.Id, _ => id++)
                .RuleFor(x => x.CreatedAt, currentTime)
                .RuleFor(x => x.CreatedBy, createdBy)
                .RuleFor(x => x.Email, x => x.Person.Email)
                .RuleFor(x => x.Password, f => f.Internet.Password())
                .RuleFor(x => x.FirstName, x => x.Person.FirstName)
                .RuleFor(x => x.LastName, x => x.Person.LastName);

            var users = userFaker.Generate(amount);

            return users;
        }

    }
}
