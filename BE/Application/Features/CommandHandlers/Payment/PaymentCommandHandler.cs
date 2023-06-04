using Application.Features.Commands.Payment;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.CommandHandlers
{
    internal sealed class PaymentCommandHandler
        : IRequestHandler<PayLessonsCommand, Unit>
    {
        private readonly IRepository<Payment> _paymentRepository;

        public PaymentCommandHandler(IRepository<Payment> paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<Unit> Handle(PayLessonsCommand request, CancellationToken cancellationToken)
        {
            var payments = await _paymentRepository.Read()
                .Include(p => p.Lesson)
                .Where(p => p.Method == PaymentMethod.Unpaid &&
                    p.StudentId == request.StudentId)
                .ToListAsync(cancellationToken);

            var sumToPay = await _paymentRepository.Read()
                .Where(p => p.Method == PaymentMethod.Unpaid &&
                    p.StudentId == request.StudentId)
                .SumAsync(p => p.Lesson.Price, cancellationToken);

            if (sumToPay != request?.Amount)
            {
                throw new BadRequestException("Transaction failed!");
            }

            var dateTime = DateTimeOffset.UtcNow;

            foreach (var payment in payments)
            {
                payment.Method = request.PaymentMethod;
                payment.Timestamp = dateTime;
                payment.Lesson.Status = LessonStatus.BookedPaid;
            }

            _paymentRepository.UpdateRange(payments);

            return Unit.Value;
        }
    }
}
