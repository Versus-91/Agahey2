using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Agahey.Authorization;

namespace Agahey
{
    [DependsOn(
        typeof(AgaheyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AgaheyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AgaheyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AgaheyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
