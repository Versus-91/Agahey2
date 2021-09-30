using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Agahey.Web.Views
{
    public abstract class AgaheyRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AgaheyRazorPage()
        {
            LocalizationSourceName = AgaheyConsts.LocalizationSourceName;
        }
    }
}
