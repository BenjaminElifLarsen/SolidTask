using SolidTask.Repositories;
using SolidTask.Repositories.Context;

namespace SolidTask.Repositories.Implementations;

public class InMemoryRepository<TEntity, TContext> : IBaseRepository<TEntity> where TEntity : class where TContext : IStore
{
    private readonly IStore _store;

    public InMemoryRepository(IStore store)
    {
        _store = store;
    }

    public IEnumerable<TEntity> All => _store.All.Where(x => x is TEntity).Select(x => (TEntity)x);

    public void Add(TEntity entity)
    {
        _store.Add(entity);
    }
}
