using Microsoft.EntityFrameworkCore;

namespace SolidTask.Services;

public class EntityFrameworkRepository<TEntity, TContext> : IBaseRepository<TEntity> where TEntity : class where TContext : DbContext
{
    private readonly TContext _context;
    private readonly DbSet<TEntity> _entities;

    public EntityFrameworkRepository(TContext context)
    {
        _context = context;
        _entities = _context.Set<TEntity>();
    }

    public IEnumerable<TEntity> All => _entities;

    public void Add(TEntity entity)
    {
        _context.Add(entity);
        _context.SaveChanges(); //would normally have an unit of work for this
    }
}
