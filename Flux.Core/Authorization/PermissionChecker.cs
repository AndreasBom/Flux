using Abp.Authorization;
using Flux.Authorization.Roles;
using Flux.MultiTenancy;
using Flux.Users;

namespace Flux.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
