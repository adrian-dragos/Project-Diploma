using Application.DTOs.Instructor;
using MediatR;

namespace Application.Features.Queries.Instructor
{
    public sealed class GetInstructorListQuery : IRequest<IEnumerable<InstructorProfileDto>>
    { 

    }
}
