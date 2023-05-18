using Application.Features.Commands.User;
using Application.Features.Services.Interfaces;
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.CommandHandlers
{
    internal sealed class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, string>
    {
        private readonly IRepository<Identity> _userReposiotry;
        private readonly IJwtProvider _jwtProvider;
        private readonly IPasswordService _passwordService;

        public LoginUserCommandHandler(
            IRepository<Identity> userReposiotry,
            IJwtProvider jwtProvider,
            IPasswordService passwordService)
        {
            _userReposiotry = userReposiotry;
            _jwtProvider = jwtProvider;
            _passwordService = passwordService;
        }

        public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userReposiotry
                .Read()
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Email == request.Email, cancellationToken);

            if (user is null || !_passwordService.VerifyPasswrord(request.Password, user.Password))
            {
                throw new BadRequestException("Wrong credentials!");
            }

            var jwtToken = _jwtProvider.Generate(user);

            return jwtToken;
        }
    }
}
