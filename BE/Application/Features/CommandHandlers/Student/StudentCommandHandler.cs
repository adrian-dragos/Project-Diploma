using Application.Features.Commands.Student;
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.CommandHandlers
{
    internal sealed class StudentCommandHandler
        : IRequestHandler<UpdateStudentProfileCommand, Unit>
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentCommandHandler(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Unit> Handle(UpdateStudentProfileCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository
                .Read()
                .Include(s => s.Identity)
                .FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken);

            if (student is null)
            {
                throw new EntityNotFoundException(typeof(Student), request.Id);
            }

            student.Identity.Email = request.Email;
            student.Identity.PhoneNumber = request.PhoneNumber;
            student.GearType = request.CarGear;
            student.Identity.FirstName = request.FirstName;
            student.Identity.LastName = request.LastName;

            _studentRepository.Update(student);

            return Unit.Value;
        }

    }
}
