using SolidTask.Models;

namespace SolidTask.Services;
internal interface IHerbavoreRepository
{
    public IEnumerable<Herbavore> All { get; }
}
