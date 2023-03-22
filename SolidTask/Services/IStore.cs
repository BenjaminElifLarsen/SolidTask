using SolidTask.Models;

namespace SolidTask.Services;
internal interface IStore
{
    public void Add(Animal entity);

    public IEnumerable<Animal> All { get; }
}
