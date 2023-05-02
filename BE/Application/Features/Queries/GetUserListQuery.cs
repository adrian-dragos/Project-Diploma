using Application.DTOs.User;
using MediatR;

namespace Application.Features.Queries
{
    public class GetUserListQuery : IRequest<IEnumerable<UserDto>>
    {
    }
}
