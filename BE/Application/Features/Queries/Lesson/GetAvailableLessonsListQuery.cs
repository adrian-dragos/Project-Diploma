using Application.DTOs.Lesson;
using Domain.Enums;
using MediatR;

namespace Application.Features.Queries.Lesson
{
    public sealed class GetAvailableLessonsListQuery : IRequest<IEnumerable<GetAvailableLessonsDto>>
    {
        public CarGear CarGear { get; set; }
        public string CarManufacturer { get; set; }
        public string CarModel { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
