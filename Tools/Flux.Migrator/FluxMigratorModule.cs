using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Flux.EntityFramework;

namespace Flux.Migrator
{
    [DependsOn(typeof(FluxDataModule))]
    public class FluxMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<FluxDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}