using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal sealed class IdentityConfiguration : IEntityTypeConfiguration<Identity>
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
               .HasForeignKey(bc => bc.RoleId);

            builder.HasData(GetUsers());
        }

        private IReadOnlyCollection<Identity> GetUsers()
        {
            var id = 1;
            int amount = 50;
            var currentTime = new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var createdBy = "System Seeding";
            var random = new Random(42);
            var password = "test";
            var names = new string[]
            {
                "John Smith",
                "Sarah Johnson",
                "Michael Brown",
                "Emily Davis",
                "Christopher Wilson",
                "Jessica Taylor",
                "Matthew Anderson",
                "Olivia Martinez",
                "David Thomas",
                "Emma Thompson",
                "Andrew Garcia",
                "Sophia Rodriguez",
                "Daniel Clark",
                "Ava Lewis",
                "James Walker",
                "Isabella Wright",
                "Joseph Turner",
                "Mia Mitchell",
                "William Hill",
                "Charlotte Young",
                "Benjamin Allen",
                "Abigail Scott",
                "Alexander King",
                "Elizabeth Baker",
                "Ryan Phillips",
                "Natalie Nelson",
                "Samuel Hill",
                "Grace Carter",
                "Daniel White",
                "Chloe Lewis",
                "Jonathan Rodriguez",
                "Sophie Mitchell",
                "William Martin",
                "Madison Adams",
                "Joseph Turner",
                "Lily Campbell",
                "Joshua Cooper",
                "Victoria Rivera",
                "Andrew Reed",
                "Hannah Ward",
                "Christopher Brooks",
                "Zoe Ramirez",
                "Jacob Morgan",
                "Avery Reed",
                "Nathan Bennett",
                "Samantha Cox",
                "David Gray",
                "Alyssa Flores",
                "Ethan Bell",
                "Lauren Butler"
            };

            var userFaker = new Faker<Identity>()
                .RuleFor(u => u.CreatedAt, _ => currentTime)
                .RuleFor(u => u.CreatedBy, _ => createdBy)
                .RuleFor(u => u.Email, f => f.Person.Email)
                .RuleFor(u => u.Password, _ => password)
                .RuleFor(u => u.FirstName, _ => names[id - 1].Split(' ')[0])
                .RuleFor(u => u.LastName, _ => names[id - 1].Split(' ')[1])
                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber("074# ### ###"))
                .RuleFor(u => u.Birthday, f => DateOnly.FromDateTime(f.Date.Between(DateTime.Now.AddYears(-50), DateTime.Now.AddYears(-25))))
                .RuleFor(u => u.RoleId, _ => random.Next(2, 4))
                .RuleFor(u => u.Id, _ => id++);

            var users = userFaker.Generate(amount);

            users.Add(new Identity
            {
                Id = 1000,
                CreatedAt = currentTime,
                CreatedBy = createdBy,
                FirstName = "Soifa",
                LastName = "Lopez",
                PhoneNumber = "0 721 123 456",
                RoleId = 1,
                Password= password,
                Email = "sofia.lopez@example.com",
            });

            return users;
        }
    }
}
