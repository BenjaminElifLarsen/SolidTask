using SolidTask.Models;

namespace SolidTask.Repositories.Abstracts;
public class HerbavoreRepository : IHerbavoreRepository
{
    private readonly IBaseRepository<Herbavore> _store;

    public HerbavoreRepository(IBaseRepository<Herbavore> store)
    {
        _store = store;
    }

    public IEnumerable<Herbavore> All => _store.All;
}
