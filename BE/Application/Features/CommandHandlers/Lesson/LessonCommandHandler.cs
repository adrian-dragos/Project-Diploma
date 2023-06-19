using Application.DTOs.Lesson;
using Application.Features.Commands.Lesson;
using Application.Interfaces;
using AutoMapper;
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
        IRequestHandler<CancelLessonCommand, Unit>,
        IRequestHandler<AddLessonCommand, AddLessonResponseDto>
    {
        private readonly IRepository<Lesson> _lessonsRepository;
        private readonly IRepository<Student> _studentRepository;
        private readonly IRepository<Payment> _paymentRepository;
        private readonly IRepository<InstructorCar> _instructorCarRepository;
        private readonly IMapper _mapper;

        public LessonCommandHandler(IRepository<Lesson> lessonsRepository, IRepository<Student> studentRepository, IRepository<Payment> paymentRepository, IRepository<InstructorCar> instructorCarRepository, IMapper mapper)
        {
            _lessonsRepository = lessonsRepository;
            _studentRepository = studentRepository;
            _paymentRepository = paymentRepository;
            _instructorCarRepository = instructorCarRepository;
            _mapper = mapper;
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

            lesson.Status = LessonStatus.Unbooked;
            lesson.StudentId = null;

            var payments = await _paymentRepository.Read()
                .Where(p => p.LessonId == lesson.Id)
                .ToListAsync(cancellationToken);

            foreach (var payment in payments)
            {
                payment.StudentId = null;
                payment.Student = null;
            }
            _lessonsRepository.Update(lesson);
            _paymentRepository.UpdateRange(payments);

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

            var payments = await _paymentRepository.Read()
                .Where(p => p.LessonId == lesson.Id)
                .ToListAsync(cancellationToken);

            foreach (var payment in payments )
            {
                payment.StudentId = null;
                payment.Student = null;
            }
            _lessonsRepository.Update(lesson);
            _paymentRepository.UpdateRange(payments);


            return Unit.Value;
        }

        public async Task<AddLessonResponseDto> Handle(AddLessonCommand request, CancellationToken cancellationToken)
        {
            var lessonExistsInSameTimeInterval = await _lessonsRepository
                .Read()
                .AnyAsync(l => l.InstructorId == request.InstructorId && (
                    (request.LessonStartTime > l.StartTime &&
                       request.LessonStartTime < l.StartTime.AddMinutes(90)) ||
                    (request.LessonStartTime.AddMinutes(90) > l.StartTime &&
                        request.LessonStartTime.AddMinutes(90) < l.StartTime.AddMinutes(90)) ||
                    (request.LessonStartTime == l.StartTime &&
                        request.LessonStartTime.AddMinutes(90) == l.StartTime.AddMinutes(90)))
                    , cancellationToken);

            if (lessonExistsInSameTimeInterval)
            {
                throw new BadRequestException("There is a lesson in the same time interval.");
            }


            var carId = await _instructorCarRepository.Read()
                .Where(ic => ic.InstructorId == request.InstructorId)
                .Select(ic => ic.CarId)
                .FirstOrDefaultAsync(cancellationToken);

            if (carId == 0)
            {
                throw new BadRequestException("Instructor does not have a car.");
            }

            var lesson = await _lessonsRepository.AddAsync(new Lesson
            {
                InstructorId = request.InstructorId,
                StartTime = request.LessonStartTime,
                Price = 50,
                Status = LessonStatus.Unbooked,
                CarId = carId 
            });

            return _mapper.Map<AddLessonResponseDto>(lesson);
        }
    }
}
