using Application.DTOs.Student;
using MediatR;

namespace Application.Features.Queries.Student
{
    public sealed class GetStudentShortProfileListQuery : IRequest<IEnumerable<StudentShortProfileDto>>
    {
    }
}
