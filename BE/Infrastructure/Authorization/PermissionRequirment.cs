using Microsoft.AspNetCore.Authorization;

namespace Infrastructure.Authorization
{
    public class PermissionRequirment : IAuthorizationRequirement
    {
        public string Peremission { get; }

        public PermissionRequirment(string peremission)
        {
            Peremission = peremission;
        }
    }
}
