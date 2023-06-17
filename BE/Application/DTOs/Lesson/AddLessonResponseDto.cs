namespace Application.DTOs.Lesson
{
    public sealed class AddLessonResponseDto
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public DateTimeOffset StartTime { get; set; }
    }
}
