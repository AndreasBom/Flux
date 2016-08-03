using System.Data.Common;
using Abp.Zero.EntityFramework;
using Flux.Authorization.Roles;
using Flux.MultiTenancy;
using Flux.Users;

namespace Flux.EntityFramework
{
    public class FluxDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public FluxDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in FluxDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of FluxDbContext since ABP automatically handles it.
         */
        public FluxDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public FluxDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
