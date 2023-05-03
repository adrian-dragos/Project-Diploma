using Application.DTOs.User;
using Application.Features.Commands;
using Application.Features.Services.Interfaces;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.CommandHandlers
{
    public sealed class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, RegisterUserDto>
    {
        private readonly IRepository<User> _userReposiotry;
        private readonly IPasswordService _passwordService;
        private readonly IMapper _mapper;

        public RegisterUserCommandHandler(IRepository<User> userReposiotry, IPasswordService passwordService, IMapper mapper)
        {
            _userReposiotry = userReposiotry;
            _passwordService = passwordService;
            _mapper = mapper;
        }

        public async Task<RegisterUserDto> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var emailAlreadyRegistred = await _userReposiotry
                .Read()
                .AnyAsync(u => u.Email == request.Email);

            if (emailAlreadyRegistred) 
            {
                // TODO: throw account already exists
                Console.WriteLine("email already exists");
                throw new NotImplementedException();
            }

            var password = _passwordService.EncrytpPassword(request.Password);
            var user = new User { Email = request.Email, Password = password };

            user = await _userReposiotry
                .AddAsync(user);

            return _mapper.Map<RegisterUserDto>(user);
        }
    }
}
