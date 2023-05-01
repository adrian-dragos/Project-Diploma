using Application.DTOs.User;
using MediatR;

namespace Application.Features.User.Queries.GetUserList
{
    public class GetUserList : IRequest<IEnumerable<UserDto>>
    {
    }
}
