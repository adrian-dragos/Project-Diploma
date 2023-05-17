using Application.DTOs.Lesson;
using MediatR;

namespace Application.Features.Queries.Lesson
{
    public sealed class GetInstructorLessonsListQuery : IRequest<IEnumerable<GetInstructorLessonsListDto>>
    {
        public int InstructorId { get; set; }
    }
}
