using SolidTask.Models;

namespace SolidTask.Services;
internal interface ICarnivoreRepository
{
    public IEnumerable<Carnivore> All { get; }
}
