using Domain.Enums;

namespace WebApi.ViewModels.Student
{
    public sealed class UpdateStudentProfileViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public CarGear CarGear { get; set; }
        public DateTime Birthday { get; set; }
    }
}
