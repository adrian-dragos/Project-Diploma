namespace WebApi.ViewModels.Lesson
{
    public sealed class GetAvailableLessonsViewModel
    {
        public DateTimeOffset Date { get; set; }
        public IEnumerable<GetAvailableLessonDetailsViewModel> LessonsDetails { get; set; }
    }
}
