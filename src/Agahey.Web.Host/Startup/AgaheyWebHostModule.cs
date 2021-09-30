using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Agahey.Configuration;

namespace Agahey.Web.Host.Startup
{
    [DependsOn(
       typeof(AgaheyWebCoreModule))]
    public class AgaheyWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AgaheyWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AgaheyWebHostModule).GetAssembly());
        }
    }
}
