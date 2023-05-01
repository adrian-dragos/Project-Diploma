using Application.DTOs.User;
using Application.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.User.Queries.GetUserList
{
    public class GetUserListHandler : IRequestHandler<GetUserList, IEnumerable<UserDto>>
    {
        private readonly IRepository<Domain.Entities.User> _userRepository;
        private readonly IMapper _mapper;

        public GetUserListHandler(IRepository<Domain.Entities.User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> Handle(GetUserList request, CancellationToken cancellationToken)
        {
            var users = await _userRepository
                .Read()
                .ToListAsync(cancellationToken);

            return _mapper.Map<IEnumerable<UserDto>>(users);
        }
    }
}
