using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Agahey.Configuration.Dto;

namespace Agahey.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AgaheyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
