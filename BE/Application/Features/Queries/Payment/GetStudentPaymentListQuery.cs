using Application.DTOs.Payment;
using MediatR;

namespace Application.Features.Queries.Payment
{
    public sealed class GetStudentPaymentListQuery : IRequest<IEnumerable<GetStudentPaymentDto>>
    {
        public int StudentId { get; set; }
    }
}
