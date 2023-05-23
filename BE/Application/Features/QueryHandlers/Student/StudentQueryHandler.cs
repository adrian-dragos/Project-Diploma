using Application.DTOs.Student;
using Application.Features.Queries.Student;
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class StudentQueryHandler
        : IRequestHandler<GetStudentProfileQuery, StudentProfileDto>
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentQueryHandler(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentProfileDto> Handle(GetStudentProfileQuery request, CancellationToken cancellationToken)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);

            var studentProfile = await _studentRepository.Read()
                .AsNoTracking()
                .Where(s => s.Id == request.Id)
                .Select(s => new StudentProfileDto
                {
                    FirstName = s.Identity.FirstName,
                    LastName = s.Identity.LastName,
                    Birthday = s.Identity.Birthday ?? today,
                    Email = s.Identity.Email,
                    PhoneNumber = s.Identity.PhoneNumber,
                    Gear = s.GearType
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (studentProfile is null)
            {
                throw new EntityNotFoundException(typeof(Student), request.Id);
            }

            return studentProfile;
        }
    }
}
