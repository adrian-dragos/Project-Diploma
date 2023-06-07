using Application.DTOs.User;
using Application.Features.Queries.User;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers.User
{
    internal sealed class GetUserProfileShortQueryHandler :
        IRequestHandler<GetUserProfileShortQuery, GetUserProfileShortDto>
    {
        private readonly IRepository<Identity> _identityRepository;

        public GetUserProfileShortQueryHandler(IRepository<Identity> identityRepository)
        {
            _identityRepository = identityRepository;
        }

        public async Task<GetUserProfileShortDto> Handle(GetUserProfileShortQuery request, CancellationToken cancellationToken)
        {
            return await _identityRepository
                 .Read()
                 .AsNoTracking()
                 .Where(i => i.Id == request.Id)
                 .Select(i => new GetUserProfileShortDto
                 {
                     FullName = i.FirstName + " " + i.LastName
                 })
                 .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
