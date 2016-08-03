using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Flux.EntityFramework.Repositories
{
    public abstract class FluxRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<FluxDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected FluxRepositoryBase(IDbContextProvider<FluxDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class FluxRepositoryBase<TEntity> : FluxRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected FluxRepositoryBase(IDbContextProvider<FluxDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
