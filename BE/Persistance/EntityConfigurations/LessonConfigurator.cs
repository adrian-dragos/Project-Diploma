using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfigurations
{
    internal class LessonConfigurator : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasOne(l => l.Instructor)
                .WithMany(i => i.Lessons)
                .HasForeignKey(l => l.InstructorId);

            builder.HasOne(l => l.Student)
                .WithMany(s => s.Lessons)
                .HasForeignKey(l => l.StudentId);

             builder.HasData(GetLessons());
        }


        private IReadOnlyCollection<Lesson> GetLessons()
        {
            var now = DateTime.UtcNow;
            var createdBy = "System Seeding";

            var lessons = new List<Lesson>()
            {
                new Lesson
                {
                    Id = 1,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    StartTime = new DateTimeOffset(2023, 07, 25, 10, 0, 0, new TimeSpan(3, 0, 0)),
                    StudentId = 1,
                    InstructorId = 1
                },
                //new Lesson
                //{
                //    Id = 2,
                //    CreatedAt = now,
                //    CreatedBy = createdBy,
                //    StartTime = new DateTimeOffset(2023, 07, 25, 10, 0, 0, new TimeSpan(3, 0, 0)),
                //    StudentId = 1,
                //    InstructorId = 2
                //},
                //new Lesson
                //{
                //    Id = 3,
                //    CreatedAt = now,
                //    CreatedBy = createdBy,
                //    StartTime = new DateTimeOffset(2023, 07, 25, 10, 0, 0, new TimeSpan(3, 0, 0)),
                //    StudentId = 2,
                //    InstructorId = 1
                //},
            };

            return lessons;
        }
    }
}
