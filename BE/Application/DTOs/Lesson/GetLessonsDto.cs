using Domain.Enums;

namespace Application.DTOs
{
    public sealed record GetLessonsDto
    {
        public int Id { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }

        public string Location { get; set; }
        public string InstructorName { get; set; }
        public LessonStatus Status { get; set; }
    }
}
