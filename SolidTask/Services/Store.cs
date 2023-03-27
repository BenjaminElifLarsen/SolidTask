using SolidTask.Models;

namespace SolidTask.Services;
public class Store : IStore
{
    private List<object> _entities;
    public IEnumerable<object> All => _entities;

    public Store()
    {
        _entities = new List<object>();
    }

    public void Add(object entity)
    {
        _entities.Add(entity);
    }
}
