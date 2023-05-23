using Domain.Enums;

namespace Application.DTOs.Student
{
    public sealed class StudentProfileDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public CarGear Gear { get; set; }
    }
}
