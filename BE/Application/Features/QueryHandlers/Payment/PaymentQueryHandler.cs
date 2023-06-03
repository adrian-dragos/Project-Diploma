

using Application.DTOs.Payment;
using Application.Features.Queries.Payment;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class PaymentQueryHandler :
        IRequestHandler<GetStudentPaymentListQuery, IEnumerable<GetStudentPaymentDto>>,
        IRequestHandler<GetSumToPayQuery, decimal>
    {
        private readonly IRepository<Payment> _paymentRepository;
        private readonly IRepository<Identity> _identityRepository;

        public PaymentQueryHandler(IRepository<Payment> paymentRepository, IRepository<Identity> identityRepository)
        {
            _paymentRepository = paymentRepository;
            _identityRepository = identityRepository;
        }

        public async Task<IEnumerable<GetStudentPaymentDto>> Handle(GetStudentPaymentListQuery request, CancellationToken cancellationToken)
        {
            var payments = await _paymentRepository.Read()
                .AsNoTracking()
                .Where(p => p.StudentId == request.StudentId)
                .GroupBy(p => new { p.Timestamp, p.CreatedBy, p.Method })
                .Select(g => new GetStudentPaymentDto
                {
                    AddedBy = _identityRepository
                        .Read()
                        .Where(i => i.Email == g.Key.CreatedBy)
                        .Select(x => x.FirstName + " " + x.LastName)
                        .FirstOrDefault(),
                    Date = g.Key.Timestamp,
                    Method = g.Key.Method,
                    Sum = g.Sum(p => p.Lesson.Price)
                })
                .OrderBy(p => p.Method == PaymentMethod.Unpaid ? 0 : 1)
                .ThenByDescending(p => p.Date)
                .ToListAsync(cancellationToken);
            
            return payments;
        }

        public async Task<decimal> Handle(GetSumToPayQuery request, CancellationToken cancellationToken)
        {
            return await _paymentRepository.Read()
                .Where(p => p.Method == PaymentMethod.Unpaid &&
                    p.StudentId == request.StudentId)
                .SumAsync(p => p.Lesson.Price, cancellationToken);
        }
    }
}
