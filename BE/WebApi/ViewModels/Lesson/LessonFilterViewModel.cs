using Domain.Enums;

namespace WebApi.ViewModels.Lesson
{
    public sealed class LessonFilterViewModel
    {
        public CarGear CarGear { get; set; }
        public string CarManufacturer { get; set; }
        public string CarModel { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
