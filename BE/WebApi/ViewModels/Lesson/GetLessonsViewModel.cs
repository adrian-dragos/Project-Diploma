using Application.DTOs.Paging;
using Domain.Enums;

namespace WebApi.ViewModels.Lesson
{
    public class GetLessonsViewModel
    {
        public IEnumerable<int> StudentIds { get; set; }
        public IEnumerable<int> InstructorIds { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public IEnumerable<LessonStatus> LessonStatuses { get; set; }
        public PageDto Page { get; set; }
    }
}
