using SolidTask.Models;

namespace SolidTask.Services;
public interface IStore
{
    public void Add(Animal entity);

    public IEnumerable<Animal> All { get; }
}
