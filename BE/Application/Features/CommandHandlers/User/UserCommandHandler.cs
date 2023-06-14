using Application.DTOs.User;
using Application.Features.Commands.User;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.CommandHandlers
{
    internal sealed class UserCommandHandler :
        IRequestHandler<AddUserCommand, UserDto>
    {

        private readonly IRepository<Identity> _userRepository;
        private readonly IMapper _mapper;

        public UserCommandHandler(IRepository<Identity> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var userWithSameEmail = await _userRepository.Read()
                .AnyAsync(x => x.Email == request.Email, cancellationToken);

            if (userWithSameEmail)
            {
                throw new BadRequestException("This email is already in use!");
            }

            var user =  await _userRepository.AddAsync(new Identity
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                RoleId = request.RoleId,
                Password = "test"
            });

            return _mapper.Map<UserDto>(user);  
        }
    }
}
