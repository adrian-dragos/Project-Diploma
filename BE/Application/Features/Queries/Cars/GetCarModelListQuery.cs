using Application.DTOs.Car;
using Domain.Enums;
using MediatR;

namespace Application.Features.Queries.Cars
{
    public sealed class GetCarModelListQuery : IRequest<IEnumerable<CarModelDto>>
    {
        public CarGear CarGear { get; set; }
    }
}
