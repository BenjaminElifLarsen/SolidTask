using SolidTask.Models;

namespace SolidTask.Repositories.Abstracts;
public interface IHerbavoreRepository
{
    public IEnumerable<Herbavore> All { get; }
}
