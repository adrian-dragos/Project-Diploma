using Application.DTOs.Instructor;
using MediatR;

namespace Application.Features.Queries.Instructor
{
    public sealed class GetInstructorsShortProfileQuery : IRequest<IEnumerable<InstructorShortProfileDto>>
    {
    }
}
