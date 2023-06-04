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
        public readonly IRepository<Payment> _paymentRepository;

        public LessonCommandHandler(IRepository<Lesson> lessonsRepository, IRepository<Student> studentRepository, IRepository<Payment> paymentRepository)
        {
            _lessonsRepository = lessonsRepository;
            _studentRepository = studentRepository;
            _paymentRepository = paymentRepository;
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
            await _paymentRepository.AddAsync(new Payment
            {
               LessonId = lesson.Id,
               StudentId = request.StudentId,
               Method = PaymentMethod.Unpaid
            });

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

            var payment = await _paymentRepository.Read()
                .FirstOrDefaultAsync(p => p.LessonId == lesson.Id, cancellationToken);

            lesson.Status = LessonStatus.Unbooked;
            lesson.StudentId = null;

            _lessonsRepository.Update(lesson);
            payment.StudentId = null;
            payment.Student = null;
            _paymentRepository.Update(payment);

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

            var payment = await _paymentRepository.Read()
                .FirstOrDefaultAsync(p => p.LessonId == lesson.Id, cancellationToken);

            payment.StudentId = null;
            payment.Student = null;
            _lessonsRepository.Update(lesson);
            _paymentRepository.Update(payment);


            return Unit.Value;
        }
    }
}
