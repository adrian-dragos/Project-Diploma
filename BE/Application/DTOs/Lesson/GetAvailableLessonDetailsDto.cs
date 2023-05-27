

using Domain.Enums;

namespace Application.DTOs.Lesson
{
    public sealed class GetAvailableLessonDetailsDto
    {
        public int Id { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public string InstructorName { get; set; }
        public string CarManufacturer { get; set; }
        public string CarModel { get; set; }
        public CarGear CarGear { get; set; }
    }
}
