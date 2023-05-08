using Application.DTOs.User;
using MediatR;

namespace Application.Features.Queries.User
{
    public class GetUserQuery : IRequest<UserDto>
    {
        public int Id { get; set; }
    }
}
