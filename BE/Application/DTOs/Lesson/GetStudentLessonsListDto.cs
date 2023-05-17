namespace Application.DTOs
{
    public sealed record GetStudentLessonsListDto
    {
        public DateTimeOffset LessonDate { get; set; }
        public string Location { get; set; }
        public string InstructorName { get; set; }
    }
}
