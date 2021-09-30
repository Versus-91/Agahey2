using System.Threading.Tasks;
using Agahey.Configuration.Dto;

namespace Agahey.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
