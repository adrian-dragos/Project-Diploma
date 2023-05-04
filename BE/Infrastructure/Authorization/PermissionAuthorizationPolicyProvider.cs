using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace Infrastructure.Authorization
{
    public class PermissionAuthorizationPolicyProvider : DefaultAuthorizationPolicyProvider
    {
        public PermissionAuthorizationPolicyProvider(
            IOptions<AuthorizationOptions> options) 
            : base(options)
        {
        }

        public override async Task<AuthorizationPolicy?> GetPolicyAsync(string permissionName)
        {
            var policy = await base.GetPolicyAsync(permissionName);

            if (policy is not null)
            {
                return policy;
            }

            return new AuthorizationPolicyBuilder()
                .AddRequirements(new PermissionRequirment(permissionName))
                .Build();
        }
    }
}
