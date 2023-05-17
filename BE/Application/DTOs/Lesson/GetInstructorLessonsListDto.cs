namespace Application.DTOs.Lesson
{
    public sealed class GetInstructorLessonsListDto
    {
        public int Id { get; set; }
        public DateTimeOffset LessonDate { get; set; }
        public string Location { get; set; }
        public string StudentName { get; set; }
    }
}
