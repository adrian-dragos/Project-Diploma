using Application.DTOs.User;
using MediatR;

namespace Application.Features.Queries.User
{
    public class GetUserListQuery : IRequest<IEnumerable<UserDto>>
    {
    }
}
