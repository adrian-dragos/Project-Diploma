using Application.DTOs.User;
using MediatR;

namespace Application.Features.Commands.User
{
    public class RegisterUserCommand : IRequest<RegisterUserDto>
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }
}
