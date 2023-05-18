using Domain.Entities;
using Domain.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Persistence;

namespace Infrastructure.Authorization
{
    public sealed class PermissionService : IPermissionService
    {

        private readonly ApplicationDbContext _dbContext;
        private readonly object _syncObject = new object();
        private readonly IMemoryCache _cache;

        public PermissionService(
            ApplicationDbContext dbContext,
            IMemoryCache cache)
        {
            _dbContext = dbContext;
            _cache = cache;
        }

        public async Task<bool> HasPermissionAsync(int userId, string permission)
        {
            if (_cache.TryGetValue(userId, out bool hasPermission))
            {
                return hasPermission;
            }

            hasPermission = false;
            var userPermissions = await GetUserPermissions(userId);

            if (userPermissions.Contains(permission))
            {
                hasPermission = true;
            }

            lock (_syncObject)
            {
                _cache.Set(userId, hasPermission,
                    new MemoryCacheEntryOptions().SetAbsoluteExpiration(
                        TimeSpan.FromMinutes(2)));
            }

            return hasPermission;
        }

        private async Task<IEnumerable<string>> GetUserPermissions(int userId)
        {
            var userRoleId = await _dbContext.Set<Identity>()
              .AsNoTracking()
              .Where(u => u.Id == userId)
              .Select(u => u.Role.Id)
              .FirstOrDefaultAsync();

            var insturctors = await _dbContext.Set<Identity>()
                .AsNoTracking()
                .Where(x => x.Id == userId)
                .Select(x => x.Students)
                .FirstOrDefaultAsync();

            return await _dbContext.Set<PolicyRole>()
                .AsNoTracking()
                .Where(pr => pr.RoleId == userRoleId)
                .Select(pr => pr.Policy.Name)
                .ToListAsync();
        }
    }
}
