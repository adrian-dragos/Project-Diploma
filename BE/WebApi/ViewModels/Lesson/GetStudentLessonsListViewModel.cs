namespace WebApi.ViewModels.Lesson
{
    public sealed class GetStudentLessonsListViewModel
    {
        public DateTimeOffset LessonDate { get; set; }
        public string Location { get; set; }
        public string InstructorName { get; set; }
    }
}
