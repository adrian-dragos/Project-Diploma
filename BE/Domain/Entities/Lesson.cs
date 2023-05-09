using Domain.Entities.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Lesson : BaseEntity
    {
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public LessonSatus LessonStatus { get; set; }
    }
}
