using Abp.Authorization;
using Agahey.Authorization.Roles;
using Agahey.Authorization.Users;

namespace Agahey.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
