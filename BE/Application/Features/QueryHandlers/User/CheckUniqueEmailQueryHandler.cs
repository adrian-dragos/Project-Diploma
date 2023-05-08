using Application.Features.Queries.User;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    public class CheckUniqueEmailQueryHandler
        : IRequestHandler<CheckUniqueEmailQuery, bool>
    {
        private readonly IRepository<User> _userRepository;

        public CheckUniqueEmailQueryHandler(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(CheckUniqueEmailQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository
                .Read()
                .AnyAsync(u => u.Email == request.Email);
        }
    }
}
