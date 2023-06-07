using Application.DTOs.User;
using Application.Features.Queries.User;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers.User
{
    internal sealed class GetUserDetialsQueryHandler :
        IRequestHandler<GetUserDetailsQuery, GetUserDetailsDto>
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IRepository<Instructor> _instructorRepository;
        private readonly IRepository<Identity> _identityRepository;

        public GetUserDetialsQueryHandler(IRepository<Student> studentRepository, IRepository<Instructor> instructorRepository, IRepository<Identity> identityRepository)
        {
            _studentRepository = studentRepository;
            _instructorRepository = instructorRepository;
            _identityRepository = identityRepository;
        }

        public async Task<GetUserDetailsDto> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            var studentDetail = await _studentRepository
                .Read()
                .AsNoTracking()
                .Where(s => s.Identity.Id == request.Id)
                .Select(s => new GetUserDetailsDto
                {
                     Id= s.Id,
                     Role = "student"
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (studentDetail is not null)
            {
                return studentDetail;
            }

            var instructorDetails = await _instructorRepository
                .Read()
                .AsNoTracking()
                .Where(i => i.Identity.Id == request.Id)
                .Select(i => new GetUserDetailsDto
                {
                    Id = i.Id,
                    Role = "instructor"
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (instructorDetails is not null)
            {
                return instructorDetails;
            }

            var admin = await _identityRepository.Read()
                .AsNoTracking()
                .Where(i => i.Id == request.Id && i.RoleId == 1)
                .Select(i => new GetUserDetailsDto
                {
                    Id = i.Id,
                    Role = "admin"
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (admin is not null)
            {
                return admin;
            }

            return new GetUserDetailsDto
            {
                Role = "student",
            };
        }
    }
}
