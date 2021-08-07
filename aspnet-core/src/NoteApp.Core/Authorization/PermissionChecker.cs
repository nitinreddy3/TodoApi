using Abp.Authorization;
using NoteApp.Authorization.Roles;
using NoteApp.Authorization.Users;

namespace NoteApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
