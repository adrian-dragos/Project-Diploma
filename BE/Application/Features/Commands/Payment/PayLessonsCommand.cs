using Domain.Enums;
using MediatR;

namespace Application.Features.Commands.Payment
{
    public sealed class PayLessonsCommand : IRequest<Unit>
    {
        public int StudentId { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
