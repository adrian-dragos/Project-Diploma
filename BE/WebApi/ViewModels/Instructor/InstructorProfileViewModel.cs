using Domain.Enums;
using WebApi.ViewModels.Car;

namespace WebApi.ViewModels.Instructor
{
    public sealed class InstructorProfileViewModel
    {
        public int Id { get; set; }
        public int? PhotoId { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public IEnumerable<InstructorCarViewModel> Cars { get; set; }
        public string Location { get; set; }
        public CarGear GearType { get; set; }
    }
}
