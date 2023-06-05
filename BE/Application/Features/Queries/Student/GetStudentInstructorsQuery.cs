using Application.DTOs.Instructor;
using MediatR;

namespace Application.Features.Queries.Student
{
    public sealed class GetStudentInstructorsQuery : IRequest<IEnumerable<InstructorShortProfileDto>>
    {
        public int StudentId { get; set; }
    }
}
