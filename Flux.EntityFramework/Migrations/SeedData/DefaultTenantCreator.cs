using System.Linq;
using Flux.EntityFramework;
using Flux.MultiTenancy;

namespace Flux.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly FluxDbContext _context;

        public DefaultTenantCreator(FluxDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
