using Application.DTOs;
using MediatR;

namespace Application.Features.Queries.Lesson
{
    public sealed class GetStudentLessonsListQuery : IRequest<IEnumerable<GetStudentLessonsListDto>>
    {
        public int StudentId { get; set; }
    }
}
