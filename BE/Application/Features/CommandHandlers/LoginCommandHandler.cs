using Application.Features.Commands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.CommandHandlers
{
    public sealed class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IRepository<User> _userReposiotry;
        private readonly IJwtProvider _jwtProvider;

        public LoginCommandHandler(IRepository<User> userReposiotry, IJwtProvider jwtProvider)
        {
            _userReposiotry = userReposiotry;
            _jwtProvider = jwtProvider;
        }

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userReposiotry
                .Read()
                .FirstOrDefaultAsync(u => u.Email == request.Email, cancellationToken);

            if (user is null || user.Password != request.Password)
            {
                // TODO: throw invalid credentials
            }

            var jwtToken = _jwtProvider.Generate(user);

            return jwtToken;
        }
    }
}
