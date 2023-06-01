using MediatR;

namespace Application.Features.Commands.Lesson
{
    public class BookLessonCommand : IRequest<Unit>
    {
        public int LessonId { get; set; }

        public int StudentId { get; set; }
    }
}
