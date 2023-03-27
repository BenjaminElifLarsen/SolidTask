using SolidTask.Models;

namespace SolidTask.Services;
public interface ICarnivoreRepository
{
    public IEnumerable<Carnivore> All { get; }
}
