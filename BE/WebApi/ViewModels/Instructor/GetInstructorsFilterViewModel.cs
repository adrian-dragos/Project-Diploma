using Application.DTOs.Car;
using Domain.Enums;

namespace WebApi.ViewModels.Instructor
{
    public sealed class GetInstructorsFilterViewModel
    {
        public CarGear CarGear { get; set; }
        public IEnumerable<CarModelDto> Cars { get; set; }
    }
}
