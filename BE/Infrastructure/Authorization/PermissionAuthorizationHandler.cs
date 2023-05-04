using Domain.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.JsonWebTokens;
using System.Security.Claims;

namespace Infrastructure.Authorization
{
    public class PermissionAuthorizationHandler 
        : AuthorizationHandler<PermissionRequirment>
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public PermissionAuthorizationHandler(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context, PermissionRequirment requirement)
        {
            var userId = context
                .User
                .Claims
                .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?
                .Value;

            if (!int.TryParse(userId, out int parsedUserId))
            {
                throw new UnauthorizedExceptinon();
            }

            using var scope = _serviceScopeFactory.CreateScope();

            var permissionService = scope.ServiceProvider
                .GetRequiredService<IPermissionService>();

            var permission = await permissionService
                .GetPermissionsAsync(parsedUserId);

            if (permission.Contains(requirement.Permission))
            {
                context.Succeed(requirement);
            }
        }
    }
}
