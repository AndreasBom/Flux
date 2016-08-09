using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Flux
{
    [DependsOn(typeof(FluxCoreModule), typeof(AbpAutoMapperModule))]
    public class FluxApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}