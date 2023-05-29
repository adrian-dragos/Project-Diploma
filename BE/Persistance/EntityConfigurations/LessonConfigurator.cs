using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal class LessonConfigurator : IEntityTypeConfiguration<Lesson>
    {
        private int _LessonId = 1;
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasOne(l => l.Instructor)
                .WithMany(i => i.Lessons)
                .HasForeignKey(l => l.InstructorId);

            builder.HasOne(l => l.Student)
                .WithMany(s => s.Lessons)
                .HasForeignKey(l => l.StudentId);


            builder.HasOne(l => l.Review)
                .WithOne(r => r.Lesson)
                .HasForeignKey<Review>(r => r.LessonId);

            builder.HasData(GetLessons());
        }


        private IReadOnlyCollection<Lesson> GetLessons()
        {
            var lessons = new List<Lesson>();
            int[] manualCarIds =  { 2, 3, 5, 6, 9 };
            int[] automaticCarsIds ={ 1, 4, 7, 8, 10 };

            lessons = SeedLessons(lessons, 1, 3, manualCarIds);
            lessons = SeedLessons(lessons, 20, 23, automaticCarsIds);

            return lessons;
        }

        private List<Lesson> SeedLessons(List<Lesson> lessons, int instructorIdStar, int instructorIdEnd, int[] carIds)
        {
            var now = DateTime.UtcNow;
            var createdBy = "System Seeding";
            var random = new Random(42);

            for (int instructorId = instructorIdStar; instructorId <= instructorIdEnd; instructorId++)
            {
                var month = 6;
                for (int date = 1; date < 60; date++)
                {
                    for (double j = 8; j < 17; j += 1.50)
                    {
                        if (j == 12.5)
                        {
                            j += 1;
                        }
                        var hour = (int)Math.Floor(j);
                        var minutes = j % 1 != 0 ? 30 : 0;
                        var lesson = new Lesson
                        {
                            Id = _LessonId++,
                            CreatedAt = now,
                            CreatedBy = createdBy,
                            StartTime = new DateTimeOffset(2023, month, date % 30 == 0 ? 30 : date % 30, hour, minutes, 0, new TimeSpan(3, 0, 0)),
                            InstructorId = instructorId,
                            CarId = carIds[random.Next(1, carIds.Length)],
                            Status = LessonStatus.Unbooked
                        };

                        if (j == 11 && instructorId == 1 && month >= 7)
                        {
                            lesson.StudentId = 1;
                            lesson.Status = LessonStatus.BookedPaid;
                        }
                        if (j == 11 && instructorId == 1 && month < 7)
                        {
                            lesson.StudentId = 1;
                            lesson.Status = LessonStatus.Completed;
                        }

                        lessons.Add(lesson);
                    }

                    if (date % 30 == 0)
                    {
                        month += 1;
                    }

                }
            }

            return lessons;
        }
    }
}
