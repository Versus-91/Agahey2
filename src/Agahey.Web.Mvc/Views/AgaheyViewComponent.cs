using Abp.AspNetCore.Mvc.ViewComponents;

namespace Agahey.Web.Views
{
    public abstract class AgaheyViewComponent : AbpViewComponent
    {
        protected AgaheyViewComponent()
        {
            LocalizationSourceName = AgaheyConsts.LocalizationSourceName;
        }
    }
}
