using SolidTask.Models;

namespace SolidTask.Repositories.Abstracts;
public interface IAnimalRepository
{
    public void AddAnimal(Animal entity);
    public IEnumerable<Animal> All { get; }
}
