using MediatR;

namespace Application.Features.Queries.Payment
{
    public sealed class GetSumToPayQuery : IRequest<decimal>
    {
        public int StudentId { get; set; }
    }
}
