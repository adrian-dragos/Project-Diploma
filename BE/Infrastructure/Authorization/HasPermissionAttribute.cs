using Microsoft.AspNetCore.Authorization;

namespace Infrastructure.Authorization
{
    public sealed class HasPermissionAttribute : AuthorizeAttribute
    {
        public HasPermissionAttribute(string policy) : base(policy)
        {
        }
    }
}
