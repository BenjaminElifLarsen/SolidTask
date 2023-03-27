using SolidTask.Models;

namespace SolidTask.Services;
public class AnimalRepository : IAnimalRepository
{
    private IBaseRepository<Animal> _store;

    public AnimalRepository(IBaseRepository<Animal> store)
    {
        _store = store;
    }

    public void AddAnimal(Animal entity)
    {
        _store.Add(entity);
    }
}
