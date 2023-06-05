using Application.DTOs.Instructor;
using Application.DTOs.Student;
using Application.Features.Queries.Student;
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class StudentQueryHandler : 
        IRequestHandler<GetStudentProfileQuery, StudentProfileDto>,
        IRequestHandler<GetStudentInstructorsQuery, IEnumerable<InstructorShortProfileDto>>,
        IRequestHandler<GetStudentShortProfileListQuery, IEnumerable<StudentShortProfileDto>>
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IRepository<Instructor> _instructorRepository;

        public StudentQueryHandler(IRepository<Student> studentRepository, IRepository<Instructor> instructorRepository)
        {
            _studentRepository = studentRepository;
            _instructorRepository = instructorRepository;
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

        public async Task<IEnumerable<InstructorShortProfileDto>> Handle(GetStudentInstructorsQuery request, CancellationToken cancellationToken)
        {
            return await _instructorRepository.Read()
                .AsNoTracking()
                .Where(i => i.Lessons.Any(l => l.StudentId == request.StudentId))
                .Select(i => new InstructorShortProfileDto
                {
                    Id = i.Id,
                    FullName = i.Identity.FirstName +  " " + i.Identity.LastName
                })
                .ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<StudentShortProfileDto>> Handle(GetStudentShortProfileListQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.Read()
                .AsNoTracking()
                .Select(s => new StudentShortProfileDto
                {
                    Id = s.Id,
                    FullName = s.Identity.FirstName + " " + s.Identity.LastName
                })
                .ToListAsync(cancellationToken);
        }
    }
}
