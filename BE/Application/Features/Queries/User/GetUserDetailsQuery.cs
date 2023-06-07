using Application.DTOs.User;
using MediatR;

namespace Application.Features.Queries.User
{
    public sealed class GetUserDetailsQuery : IRequest<GetUserDetailsDto>
    {
        public int Id { get; set; }
    }
}
