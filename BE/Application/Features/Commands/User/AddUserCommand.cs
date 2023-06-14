using Application.DTOs.User;
using MediatR;

namespace Application.Features.Commands.User
{
    public sealed class AddUserCommand : IRequest<UserDto>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
    }
}
