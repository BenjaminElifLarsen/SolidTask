using SolidTask.Contracts;
using SolidTask.Models;
using SolidTask.Services;

IEnumerable<Animal> animals = new List<Animal>()
{
    new Animal("Worm",true),
    new Carnivore("Fox",false),
    new Herbavore("Bunny",false),

};

foreach (var animal in animals)
    animal.GenerateSound();

foreach (var animal in animals.Where(x => x is IEatingFood).Select(x => (IEatingFood)x))
    animal.Eat();

IStore _store = new Store();
IAnimalRepository _animalRepository = new AnimalRepository(_store);
IHerbavoreRepository _herbavoreRepository = new HerbavoreRepository(_store);
ICarnivoreRepository _carnivoreRepository = new CarnivoreRepository(_store);

foreach (var animal in animals)
    _animalRepository.AddAnimal(animal);

foreach(var herba in _herbavoreRepository.All)
    herba.GenerateSound();

foreach(var carni in _carnivoreRepository.All)
    carni.GenerateSound();

