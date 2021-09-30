using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Agahey.Controllers
{
    public abstract class AgaheyControllerBase: AbpController
    {
        protected AgaheyControllerBase()
        {
            LocalizationSourceName = AgaheyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
