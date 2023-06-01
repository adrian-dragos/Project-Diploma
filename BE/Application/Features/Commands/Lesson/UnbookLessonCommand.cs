
using MediatR;

namespace Application.Features.Commands.Lesson
{
    public sealed class UnbookLessonCommand : IRequest<Unit>
    {
        public int LessonId { get; set; }
        public int StudentId { get; set; }
    }
}
