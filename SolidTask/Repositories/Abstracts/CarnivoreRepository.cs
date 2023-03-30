using SolidTask.Models;

namespace SolidTask.Repositories.Abstracts;
public class CarnivoreRepository : ICarnivoreRepository
{
    private readonly IBaseRepository<Carnivore> _store;

    public CarnivoreRepository(IBaseRepository<Carnivore> store)
    {
        _store = store;
    }

    public IEnumerable<Carnivore> All => _store.All;
}
