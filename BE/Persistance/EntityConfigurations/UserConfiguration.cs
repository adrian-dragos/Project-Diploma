using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Identity>
    {

        public void Configure(EntityTypeBuilder<Identity> builder)
        {
            builder.Property(u => u.FirstName)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(u => u.LastName)
                .HasMaxLength(50)
                .IsRequired(false); ;

            builder.Property(u => u.Email)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(u => u.PhoneNumber)
              .HasMaxLength(20)
              .IsRequired(false);

            builder.Property(u => u.Birthday)
               .HasMaxLength(50)
               .IsRequired(false);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u => u.Password)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasOne(u => u.Role)
               .WithMany(u => u.Users)
               .HasForeignKey(bc => bc.RoleId); ;

            builder.HasData(GetUsers(10));
        }

        private IReadOnlyCollection<Identity> GetUsers(int amount)
        {
            var id = 1;
            var currentTime = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var createdBy = "System Seeding";
            var random = new Random(42);
            var password = "test";

            var userFaker = new Faker<Identity>()
                .RuleFor(u => u.Id, _ => id++)
                .RuleFor(u => u.CreatedAt, _ => currentTime)
                .RuleFor(u => u.CreatedBy, _ => createdBy)
                .RuleFor(u => u.Email, f => f.Person.Email)
                .RuleFor(u => u.Password, _ => password)
                .RuleFor(u => u.FirstName, f => f.Person.FirstName)
                .RuleFor(u => u.LastName, f => f.Person.LastName)
                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber("+40 74# ### ###"))
                .RuleFor(u => u.Birthday, f => f.Date.Between(DateTime.Now.AddYears(-50), DateTime.Now.AddYears(-25)))
                .RuleFor(u => u.RoleId, _ => random.Next(1, 4));

            var users = userFaker.Generate(amount);

            return users;
        }
    }
}
