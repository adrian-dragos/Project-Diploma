using Application.DTOs.Car;
using Application.Features.Queries.Cars;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class CarQueryHandler :
        IRequestHandler<GetCarModelListQuery, IEnumerable<CarModelDto>>
    {
        private readonly IRepository<Car> _carRepository;

        public CarQueryHandler(IRepository<Car> carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<IEnumerable<CarModelDto>> Handle(GetCarModelListQuery request, CancellationToken cancellationToken)
        {
            return await _carRepository
                .Read()
                .AsNoTracking()
                .Where(c => c.CarModel.CarGear == request.CarGear)
                .Select(c => new CarModelDto
                {
                    Manufacturer = c.CarModel.Manufacturer,
                    Model = c.CarModel.Model,
                })
                .Distinct()
                .OrderBy(c => c.Manufacturer)
                .ToListAsync(cancellationToken);
        }
    }
}
