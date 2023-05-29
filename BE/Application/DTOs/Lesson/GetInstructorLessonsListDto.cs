using Domain.Enums;

namespace Application.DTOs.Lesson
{
    public sealed class GetInstructorLessonsListDto
    {
        public int Id { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public string Location { get; set; }
        public string StudentName { get; set; }
        public LessonStatus Status { get; set; }
    }
}
