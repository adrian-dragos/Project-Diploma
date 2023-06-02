using MediatR;

namespace Application.Features.Commands.Lesson
{
    public class CancelLessonCommand : IRequest<Unit>
    {
        public int LessonId { get; set; }
    }
}
