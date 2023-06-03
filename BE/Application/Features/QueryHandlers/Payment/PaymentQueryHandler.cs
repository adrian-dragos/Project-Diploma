

using Application.DTOs.Payment;
using Application.Features.Queries.Payment;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class PaymentQueryHandler :
        IRequestHandler<GetStudentPaymentListQuery, IEnumerable<GetStudentPaymentDto>>
    {
        private readonly IRepository<Payment> _paymentRepository;
        private readonly IMapper _mapper;

        public PaymentQueryHandler(IRepository<Payment> paymentReposiotry, IMapper mapper)
        {
            _paymentRepository = paymentReposiotry;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetStudentPaymentDto>> Handle(GetStudentPaymentListQuery request, CancellationToken cancellationToken)
        {
            var payments = await _paymentRepository.Read()
                .AsNoTracking()
                .GroupBy(p => new { p.CreatedAt, p.CreatedBy, p.Method })
                .Select(g => new GetStudentPaymentDto
                {
                    AddedBy = g.Key.CreatedBy,
                    Date = g.Key.CreatedAt,
                    Method = g.Key.Method,
                    Sum = g.Sum(p => p.Lesson.Price)
                })
                .OrderByDescending(p => p.Date)
                .ToListAsync(cancellationToken);
            
            return payments;
        }
    }
}
