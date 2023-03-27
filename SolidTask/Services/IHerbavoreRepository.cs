using SolidTask.Models;

namespace SolidTask.Services;
public interface IHerbavoreRepository
{
    public IEnumerable<Herbavore> All { get; }
}
