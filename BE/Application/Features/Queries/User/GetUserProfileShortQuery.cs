using Application.DTOs.User;
using MediatR;

namespace Application.Features.Queries.User
{
    public sealed class GetUserProfileShortQuery : IRequest<GetUserProfileShortDto>
    {
        public int Id { get; set; }
    }
}
