using SolidTask.Models;

namespace SolidTask.Services;
public class HerbavoreRepository : IHerbavoreRepository
{
    private readonly IStore _store;

    public HerbavoreRepository(IStore store)
    {
        _store = store;
    }

    public IEnumerable<Herbavore> All => _store.All.Where(x => x is Herbavore).Select(x => (Herbavore)x);
}
