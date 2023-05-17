namespace WebApi.ViewModels.Lesson
{
    public sealed class GetInstructorLessonsListViewModel
    {
        public int Id { get; set; }
        public DateTimeOffset LessonDate { get; set; }
        public string Location { get; set; }
        public string StudentName { get; set; }
    }
}
