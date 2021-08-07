using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NoteApp.EntityFrameworkCore;
using NoteApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace NoteApp.Web.Tests
{
    [DependsOn(
        typeof(NoteAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class NoteAppWebTestModule : AbpModule
    {
        public NoteAppWebTestModule(NoteAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NoteAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(NoteAppWebMvcModule).Assembly);
        }
    }
}