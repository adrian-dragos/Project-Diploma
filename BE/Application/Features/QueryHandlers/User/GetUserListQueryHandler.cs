using Application.DTOs.User;
using Application.Features.Queries.User;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, IEnumerable<UserDto>>
    {
        private readonly IRepository<Identity> _userRepository;
        private readonly IMapper _mapper;

        public GetUserListQueryHandler(IRepository<Identity> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository
                .Read()
                .AsNoTracking()
                .ProjectTo<UserDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}
