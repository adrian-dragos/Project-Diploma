using Application.DTOs.Car;
using Application.Features.Queries.Cars;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class CarQueryHandler :
        IRequestHandler<GetCarModelListQuery, IEnumerable<CarModelDto>>
    {
        private readonly IRepository<Car> _carRepository;
        private readonly IMapper _mapper;

        public CarQueryHandler(IRepository<Car> carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CarModelDto>> Handle(GetCarModelListQuery request, CancellationToken cancellationToken)
        {
            return await _carRepository
                .Read()
                .AsNoTracking()
                .Where(c => c.CarGear == request.CarGear)
                .ProjectTo<CarModelDto>(_mapper.ConfigurationProvider)
                .Distinct()
                .OrderBy(c => c.Manufacturer)
                .ToListAsync(cancellationToken);
        }
    }
}
