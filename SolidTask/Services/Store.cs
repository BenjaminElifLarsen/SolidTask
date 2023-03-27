using SolidTask.Models;

namespace SolidTask.Services;
public class Store : IStore
{
    private List<Animal> _entities;
    public IEnumerable<Animal> All => _entities;

    public Store()
    {
        _entities = new List<Animal>();
    }

    public void Add(Animal entity)
    {
        _entities.Add(entity);
    }
}
