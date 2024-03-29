﻿using Application.DTOs.Payment;
using Domain.Enums;
using MediatR;

namespace Application.Features.Queries.Payment
{
    public sealed class GetStudentPaymentListQuery : IRequest<IEnumerable<GetStudentPaymentDto>>
    {
        public IEnumerable<int> StudentIds { get; set; }
        public IEnumerable<PaymentMethod> PaymentMethod { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
    }
}
