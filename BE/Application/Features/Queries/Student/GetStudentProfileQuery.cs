using Application.DTOs.Student;
using MediatR;

namespace Application.Features.Queries.Student
{
    public sealed class GetStudentProfileQuery : IRequest<StudentProfileDto>
    {
        public int Id { get; set; }
    }
}
