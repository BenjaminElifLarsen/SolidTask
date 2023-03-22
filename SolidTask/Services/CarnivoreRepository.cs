using SolidTask.Models;

namespace SolidTask.Services;
internal class CarnivoreRepository : ICarnivoreRepository
{
    private readonly IStore _store;

    public CarnivoreRepository(IStore store)
    {
        _store = store;
    }

    public IEnumerable<Carnivore> All => _store.All.Where(x => x is Carnivore).Select(x => (Carnivore)x);
}
