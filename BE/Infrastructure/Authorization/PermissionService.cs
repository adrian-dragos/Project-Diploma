using Domain.Entities;
using Domain.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace Infrastructure.Authorization
{
    public sealed class PermissionService : IPermissionService
    {

        private readonly ApplicationDbContext _dbContext;

        public PermissionService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<string>> GetPermissionsAsync(int userId)
        {
            var userRoleId = await _dbContext.Set<User>()
                .AsNoTracking()
                .Where(u => u.Id == userId)
                .Select(u => u.Role.Id)
                .FirstOrDefaultAsync();

            var userPermissions = await _dbContext.Set<PolicyRole>()
                .AsNoTracking()
                .Where(pr => pr.RoleId == userRoleId)
                .Select(pr => pr.Policy.Name)
                .ToListAsync();

            return userPermissions;
        }
    }
}
