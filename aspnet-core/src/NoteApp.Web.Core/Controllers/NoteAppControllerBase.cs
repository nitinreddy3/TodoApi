using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NoteApp.Controllers
{
    public abstract class NoteAppControllerBase: AbpController
    {
        protected NoteAppControllerBase()
        {
            LocalizationSourceName = NoteAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
