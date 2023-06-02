using Application.Features.Commands.Lesson;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.CommandHandlers
{
    internal sealed class LessonCommandHandler :
        IRequestHandler<BookLessonCommand, Unit>,
        IRequestHandler<UnbookLessonCommand, Unit>,
        IRequestHandler<CancelLessonCommand, Unit>
    {
        public readonly IRepository<Lesson> _lessonsRepository;
        public readonly IRepository<Student> _studentRepository;

        public LessonCommandHandler(IRepository<Lesson> lessonsRepository, IRepository<Student> studentRepository)
        {
            _lessonsRepository = lessonsRepository;
            _studentRepository = studentRepository;
        }

        public async Task<Unit> Handle(BookLessonCommand request, CancellationToken cancellationToken)
        {
            var lesson = await _lessonsRepository
                .Read()
                .FirstOrDefaultAsync(l => l.Id == request.LessonId, cancellationToken);

            await _studentRepository.TryGetByIdAsync(request.StudentId, cancellationToken);

            if (lesson is null)
            {
                throw new EntityNotFoundException(typeof(Lesson), request.LessonId);
            }

            var selectLessonStartTime = lesson.StartTime;
            var selectedLessonEndTime = lesson.StartTime.AddMinutes(90);

            var lessonAtSameTimeBooked = await _lessonsRepository
                .Read()
                .AsNoTracking()
                .FirstOrDefaultAsync(l => l.Student.Id == request.StudentId && (
                                (l.StartTime > selectLessonStartTime && l.StartTime < selectedLessonEndTime) ||
                                (l.StartTime.AddMinutes(90) > selectLessonStartTime && l.StartTime.AddMinutes(90) < selectedLessonEndTime) || 
                                (l.StartTime == selectLessonStartTime && l.StartTime.AddMinutes(90) == selectedLessonEndTime)),
                                cancellationToken); 
            

            if (lessonAtSameTimeBooked is not null)
            {
                throw new BadRequestException("There is already a lesson with booked for this time slot!");
            }

            if (lesson.Status != LessonStatus.Unbooked)
            {
                throw new BadRequestException($"Could not perform operation for lesson with {lesson.Status} status!");
            }

            if (lesson.StartTime.AddMinutes(90) <= DateTimeOffset.Now) 
            {
                throw new BadRequestException("Booking is only available for lessons that are at least 90 minutes in the future or are upcoming.");
            }

            lesson.Status = LessonStatus.BookedNotPaid;
            lesson.StudentId = request.StudentId;

            _lessonsRepository.Update(lesson);

            return Unit.Value;
        }

        public async Task<Unit> Handle(UnbookLessonCommand request, CancellationToken cancellationToken)
        {
            var lesson = await _lessonsRepository
               .Read()
               .FirstOrDefaultAsync(l => l.Id == request.LessonId, cancellationToken);

            await _studentRepository.TryGetByIdAsync(request.StudentId, cancellationToken);

            if (lesson is null)
            {
                throw new EntityNotFoundException(typeof(Lesson), request.LessonId);
            }

            if (lesson.Status != LessonStatus.BookedNotPaid)
            {
                throw new BadRequestException($"Could not perform operation for lesson with {lesson.Status} status!");
            }

            lesson.Status = LessonStatus.Unbooked;
            lesson.StudentId = null;

            _lessonsRepository.Update(lesson);

            return Unit.Value;
        }

        public async Task<Unit> Handle(CancelLessonCommand request, CancellationToken cancellationToken)
        {
            var lesson = await _lessonsRepository
               .Read()
               .FirstOrDefaultAsync(l => l.Id == request.LessonId, cancellationToken);

            if (lesson is null)
            {
                throw new EntityNotFoundException(typeof(Lesson), request.LessonId);
            }

            if (lesson.Status != LessonStatus.BookedPaid)
            {
                throw new BadRequestException($"Could not perform operation for lesson with {lesson.Status} status!");
            }

            if (lesson.StartTime <= DateTimeOffset.Now)
            {
                throw new BadRequestException($"Can not delete past lessons!");
            }

            lesson.Status = LessonStatus.Unbooked;
            lesson.StudentId = null;

            _lessonsRepository.Update(lesson);

            return Unit.Value;
        }
    }
}
