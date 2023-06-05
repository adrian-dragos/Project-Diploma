using Application.DTOs.Student;
using MediatR;

namespace Application.Features.Queries.Instructor
{
    public sealed class GetInstructorStudentsQuery : IRequest<IEnumerable<StudentShortProfileDto>>
    {
        public int InstructorId { get; set; }
    }
}
