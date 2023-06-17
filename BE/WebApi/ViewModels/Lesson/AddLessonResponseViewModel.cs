namespace WebApi.ViewModels.Lesson
{
    public class AddLessonResponseViewModel
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public DateTimeOffset StartTime { get; set; }
    }
}
