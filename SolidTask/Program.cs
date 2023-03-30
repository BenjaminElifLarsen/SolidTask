using SolidTask.Models;
using SolidTask.Models.Contracts;
using SolidTask.Repositories;
using SolidTask.Repositories.Abstracts;
using SolidTask.Repositories.Context;
using SolidTask.Repositories.Implementations;

IEnumerable<Animal> animals = new List<Animal>()
{
    new Herbavore("Worm",true,"Worm sounds"),
    new Carnivore("Fox",false, "SCREAM"),
    new Herbavore("Bunny",false, "Cute bunny sounds"),
};

foreach (var animal in animals)
    animal.GenerateSound();

foreach (var eaters in animals.Where(x => x is IEatingFood).Select(x => (IEatingFood)x))
    eaters.Eat();


foreach (var hunters in animals.Where(x => x is IHuntingFood).Select(x => (IHuntingFood)x))
    hunters.Hunt();

IStore _store = new Store();
IBaseRepository<Animal> _animalRepo = new InMemoryRepository<Animal, IStore>(_store);
IBaseRepository<Herbavore> _herbaRepo = new InMemoryRepository<Herbavore, IStore>(_store);
IBaseRepository<Carnivore> _carniRepo = new InMemoryRepository<Carnivore, IStore>(_store);
IAnimalRepository _animalRepository = new AnimalRepository(_animalRepo);
IHerbavoreRepository _herbavoreRepository = new HerbavoreRepository(_herbaRepo);
ICarnivoreRepository _carnivoreRepository = new CarnivoreRepository(_carniRepo);

foreach (var animal in animals)
    _animalRepository.AddAnimal(animal);

foreach(var herba in _herbavoreRepository.All)
    herba.GenerateSound();

foreach(var carni in _carnivoreRepository.All)
    carni.GenerateSound();

