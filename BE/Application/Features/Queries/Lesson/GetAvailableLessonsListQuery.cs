using Application.DTOs.Car;
using Application.DTOs.Lesson;
using Domain.Enums;
using MediatR;

namespace Application.Features.Queries.Lesson
{
    public sealed class GetAvailableLessonsListQuery : IRequest<IEnumerable<GetAvailableLessonsDto>>
    {
        public int? InstructorId { get; set; }
        public CarGear CarGear { get; set; }
        public IEnumerable<CarModelDto> CarModels { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
