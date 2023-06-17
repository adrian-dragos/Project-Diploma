using Application.DTOs.Lesson;
using MediatR;

namespace Application.Features.Commands.Lesson
{
    public sealed class AddLessonCommand : IRequest<AddLessonResponseDto>
    {
        public DateTimeOffset LessonStartTime { get; set; }
        public int InstructorId { get; set; }
    }
}
