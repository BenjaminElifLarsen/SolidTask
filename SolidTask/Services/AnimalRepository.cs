using SolidTask.Models;

namespace SolidTask.Services;
internal class AnimalRepository : IAnimalRepository
{
    private IStore _store;

    public AnimalRepository(IStore store)
    {
        _store = store;
    }

    public void AddAnimal(Animal entity)
    {
        _store.Add(entity);
    }
}
