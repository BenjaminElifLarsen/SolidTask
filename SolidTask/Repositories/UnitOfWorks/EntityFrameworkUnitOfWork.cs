using SolidTask.Repositories.Abstracts;
using SolidTask.Repositories.Context;

namespace SolidTask.Repositories.UnitOfWorks;
public class EntityFrameworkUnitOfWork : IUnitOfWork
{
    private readonly DataContext _context;
    private readonly IAnimalRepository _animalRepository;
    private readonly ICarnivoreRepository _carnivoreRepository;
    private readonly IHerbavoreRepository _herbavoreRepository;
    public EntityFrameworkUnitOfWork(DataContext dataContext, IAnimalRepository animalRepository, ICarnivoreRepository carnivoreRepository, IHerbavoreRepository herbavoreRepository)
    {
        _animalRepository = animalRepository;
        _carnivoreRepository = carnivoreRepository;
        _herbavoreRepository = herbavoreRepository;
        _context = dataContext;
    }

    public IAnimalRepository AnimalRepository => _animalRepository;

    public ICarnivoreRepository CarnivoreRepository => _carnivoreRepository;

    public IHerbavoreRepository HerbavoreRepository => _herbavoreRepository;

    public void Save()
    {
        _context.SaveChanges();
    }
}
