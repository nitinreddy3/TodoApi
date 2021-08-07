using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NoteApp.Authorization;

namespace NoteApp
{
    [DependsOn(
        typeof(NoteAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NoteAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NoteAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NoteAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
