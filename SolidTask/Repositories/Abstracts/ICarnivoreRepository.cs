using SolidTask.Models;

namespace SolidTask.Repositories.Abstracts;
public interface ICarnivoreRepository
{
    public IEnumerable<Carnivore> All { get; }
}
