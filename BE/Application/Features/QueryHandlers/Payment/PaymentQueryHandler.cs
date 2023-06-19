

using Application.DTOs.Payment;
using Application.DTOs.Student;
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
        IRequestHandler<GetSumToPayQuery, decimal>,
        IRequestHandler<GetStudentListPaymentQuery, IEnumerable<StudentShortProfileDto>>
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
            var paymentsQuery = _paymentRepository.Read()
                .AsNoTracking()
                .Where(p => p.StudentId != null);

            if (request.StudentIds?.Any() ?? false)
            {
                paymentsQuery = paymentsQuery
                    .Where(p => request.StudentIds.Contains((int)p.StudentId));
            }

            if (request.PaymentMethod?.Any() ?? false)
            {
                paymentsQuery = paymentsQuery.Where(p => request.PaymentMethod.Contains(p.Method) || p.Method == PaymentMethod.Unpaid);
            }

            if (request.StartDate is not null)
            {
                var startDate = request.StartDate.GetValueOrDefault().AddDays(1).Date;
                paymentsQuery = paymentsQuery.Where(p => p.Timestamp.Date >= startDate);
            }

            if (request.EndDate is not null)
            {
                var endDate = request.EndDate.GetValueOrDefault().AddDays(1).Date;
                paymentsQuery = paymentsQuery.Where(p => p.Timestamp.Date <= endDate);
            }

            var payments = await paymentsQuery
                .GroupBy(p => new { p.Timestamp, p.CreatedBy, p.Method, p.StudentId })
                .Select(g => new GetStudentPaymentDto
                {
                    AddedBy = _identityRepository
                        .Read()
                        .Where(i => i.Email == g.Key.CreatedBy)
                        .Select(x => x.FirstName + " " + x.LastName)
                        .FirstOrDefault(),
                    Date = g.Key.Timestamp,
                    Method = g.Key.Method,
                    Sum = g.Sum(p => p.Lesson.Price),
                    StudentId = g.Key.StudentId ?? 0
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

        public async Task<IEnumerable<StudentShortProfileDto>> Handle(GetStudentListPaymentQuery request, CancellationToken cancellationToken)
        {
            return await _paymentRepository.Read()
                  .Where(p => p.StudentId != null &&  (
                                p.Method == PaymentMethod.Unpaid ||
                                p.Method == PaymentMethod.Cash ||
                                p.Method == PaymentMethod.Card))
                  .Select(p => new StudentShortProfileDto
                  {
                      Id = p.Student.Id,
                      FullName = p.Student.Identity.FirstName + " " + p.Student.Identity.LastName,
                  })
                  .Distinct()
                  .ToListAsync(cancellationToken);
        }
    }
}
