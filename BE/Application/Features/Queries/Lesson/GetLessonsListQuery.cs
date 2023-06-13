using Application.DTOs;
using Application.DTOs.Pagination;
using Application.DTOs.Paging;
using Domain.Enums;
using MediatR;

namespace Application.Features.Queries.Lesson
{
    public sealed class GetLessonsListQuery : IRequest<PagedResultDto<GetLessonsDto>>
    {
        public IEnumerable<int> StudentIds { get; set; }
        public IEnumerable<int> InstructorIds { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public IEnumerable<LessonStatus> LessonStatuses { get; set; }
        public PageDto Page { get; set; }
    }
}
