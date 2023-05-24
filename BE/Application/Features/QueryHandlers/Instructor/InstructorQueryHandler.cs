using Application.DTOs.Car;
using Application.DTOs.Instructor;
using Application.Features.Queries.Instructor;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class InstructorQueryHandler :
        IRequestHandler<GetInstructorListQuery, IEnumerable<InstructorProfileDto>>
    {
        public readonly IRepository<Instructor> _instructorRepository;

        public InstructorQueryHandler(IRepository<Instructor> instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        public async Task<IEnumerable<InstructorProfileDto>> Handle(GetInstructorListQuery request, CancellationToken cancellationToken)
        {
            return await _instructorRepository
                .Read()
                .AsNoTracking()
                .Where(i => i.GearType == request.GearType)
                .Select(i => new InstructorProfileDto
                {
                    Id = i.Id,
                    PhotoId = 0,
                    PhoneNumber = i.Identity.PhoneNumber,
                    FullName = i.Identity.FirstName + " " + i.Identity.LastName,
                    Cars = i.InstructorCars
                        .Select(ic => new InstructorCarDto {
                            Name = ic.Car.Manufacturer + " " + ic.Car.Model,
                            RegistrationNumber = ic.Car.RegistrationNumber
                        })
                        .ToList(),
                    Location = i.Location
                })
                .ToListAsync(cancellationToken);
        }
    }
}
