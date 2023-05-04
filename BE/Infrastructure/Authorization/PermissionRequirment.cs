using Microsoft.AspNetCore.Authorization;

namespace Infrastructure.Authorization
{
    public class PermissionRequirment : IAuthorizationRequirement
    {
        public string Permission { get; }

        public PermissionRequirment(string permission)
        {
            Permission = permission;
        }
    }
}
