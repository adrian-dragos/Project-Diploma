﻿using Application.Features.Queries.User;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class CheckUniqueEmailQueryHandler
        : IRequestHandler<CheckUniqueEmailQuery, bool>
    {
        private readonly IRepository<Identity> _userRepository;

        public CheckUniqueEmailQueryHandler(IRepository<Identity> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(CheckUniqueEmailQuery request, CancellationToken cancellationToken)
        {
            return !await _userRepository
                .Read()
                .AnyAsync(u => u.Email == request.Email);
        }
    }
}
