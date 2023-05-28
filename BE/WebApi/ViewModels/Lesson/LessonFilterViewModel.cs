using Domain.Enums;
using WebApi.ViewModels.Car;

namespace WebApi.ViewModels.Lesson
{
    public sealed class LessonFilterViewModel
    {
        public int? InstructorId { get; set; }
        public CarGear CarGear { get; set; }
        public CarModelViewModel[] CarModels { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
