using Application.DTOs.Car;
using Domain.Enums;

namespace Application.DTOs.Instructor
{
    public sealed class InstructorProfileDto
    {
        public int Id { get; set; }
        public int? PhotoId { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public IEnumerable<CarModelDto> CarModels { get; set; }
        public string Location { get; set; }
        public CarGear GearType { get; set; }
    }
}
