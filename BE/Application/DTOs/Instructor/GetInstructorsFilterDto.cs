using Application.DTOs.Car;
using Domain.Enums;

namespace Application.DTOs.Instructor
{
    public sealed class GetInstructorsFilterDto
    {
        public CarGear CarGear { get; set; }
        public IEnumerable<CarModelDto>? Cars { get; set; }
    }
}