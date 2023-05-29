using Domain.Enums;

namespace WebApi.ViewModels.Student
{
    public sealed class UpdateStudentProfileViewModel
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public CarGear CarGear { get; set; }
    }
}
