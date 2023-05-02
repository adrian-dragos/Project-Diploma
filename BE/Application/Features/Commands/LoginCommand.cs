using MediatR;

namespace Application.Features.Commands
{
    public class LoginCommand : IRequest<string>
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }
}
