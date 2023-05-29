using Application.DTOs;
using Application.DTOs.Pagination;
using Application.DTOs.Paging;
using MediatR;

namespace Application.Features.Queries.Lesson
{
    public sealed class GetStudentLessonsListQuery : IRequest<PagedResultDto<GetStudentLessonsListDto>>
    {
        public int StudentId { get; set; }
        public PageDto PageDto { get; set; }
    }
}
