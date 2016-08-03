using Flux.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Flux.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly FluxDbContext _context;

        public InitialHostDbBuilder(FluxDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
