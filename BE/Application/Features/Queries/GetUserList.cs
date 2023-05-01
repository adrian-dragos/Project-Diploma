using Application.DTOs.User;
using MediatR;

namespace Application.Features.Queries
{
    public class GetUserList : IRequest<IEnumerable<UserDto>>
    {
    }
}
