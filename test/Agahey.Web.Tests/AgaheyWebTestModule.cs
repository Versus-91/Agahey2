using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Agahey.EntityFrameworkCore;
using Agahey.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Agahey.Web.Tests
{
    [DependsOn(
        typeof(AgaheyWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AgaheyWebTestModule : AbpModule
    {
        public AgaheyWebTestModule(AgaheyEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AgaheyWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AgaheyWebMvcModule).Assembly);
        }
    }
}