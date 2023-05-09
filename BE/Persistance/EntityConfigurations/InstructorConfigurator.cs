using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfigurations
{
    internal class InstructorConfigurator : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasData(GetInstructors());
        }

        private IReadOnlyCollection<Instructor> GetInstructors()
        {
            var now = DateTime.UtcNow;
            var createdBy = "System Seeding";

            var instructors = new List<Instructor>()
            {
                new Instructor
                {
                    Id = 1,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 4,
                },
                new Instructor
                {
                    Id = 2,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 8
                }
            };
            return instructors;
        }
    }
}
