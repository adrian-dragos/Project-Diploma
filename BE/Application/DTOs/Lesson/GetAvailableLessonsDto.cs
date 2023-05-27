namespace Application.DTOs.Lesson
{
    public sealed class GetAvailableLessonsDto
    {
        public DateTimeOffset Date { get; set; }
        public IEnumerable<GetAvailableLessonDetailsDto> LessonsDetails { get; set; }
    }
}
