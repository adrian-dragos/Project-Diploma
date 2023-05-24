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
                .Select(i => new InstructorProfileDto
                {
                    Id = i.Id,
                    PhotoId = 0,
                    PhoneNumber = i.Identity.PhoneNumber,
                    FullName = i.Identity.FirstName + " " + i.Identity.LastName,
                    CarName = "Dacia Sandero",
                    RegistrationNumber = "TM 140 EMT",
                    Spot = "Unknown"
                })
                .ToListAsync();
        }
    }
}
