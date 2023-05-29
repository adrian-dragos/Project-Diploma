using Application.DTOs.Lesson;
using Application.DTOs.Pagination;
using Application.DTOs.Paging;
using MediatR;

namespace Application.Features.Queries.Lesson
{
    public sealed class GetInstructorLessonsListQuery : IRequest<PagedResultDto<GetInstructorLessonsListDto>>
    {
        public int InstructorId { get; set; }
        public PageDto PageDto { get; set; }
    }
}
