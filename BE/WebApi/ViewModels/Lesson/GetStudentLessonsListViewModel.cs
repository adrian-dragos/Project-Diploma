using Domain.Enums;

namespace WebApi.ViewModels.Lesson
{
    public sealed class GetStudentLessonsListViewModel
    {
        public int Id { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public string Location { get; set; }
        public string InstructorName { get; set; }
        public LessonStatus Status { get; set; }
    }
}
