using Application.DTOs.User;
using Application.Features.Queries.User;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
    {
        private readonly IRepository<Identity> _userRepository;
        private readonly IMapper _mapper;

        public GetUserQueryHandler(IRepository<Identity> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository
                   .Read()
                   .AsNoTracking()
                   .ProjectTo<UserDto>(_mapper.ConfigurationProvider)
                   .FirstOrDefaultAsync(u => u.Id == request.Id, cancellationToken);

            if (user is null)
            {
                throw new EntityNotFoundException(typeof(Identity), request.Id);
            }

            return user;
        }
    }
}
