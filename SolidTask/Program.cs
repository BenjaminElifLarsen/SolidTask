﻿using SolidTask.Contracts;
using SolidTask.Models;
using SolidTask.Repositories;
using SolidTask.Repositories.Abstracts;
using SolidTask.Repositories.Context;
using SolidTask.Repositories.Implementations;

IEnumerable<Animal> animals = new List<Animal>()
{
    new Herbavore("Worm",true),
    new Carnivore("Fox",false),
    new Herbavore("Bunny",false),

};

foreach (var animal in animals)
    animal.GenerateSound();

foreach (var animal in animals.Where(x => x is IEatingFood).Select(x => (IEatingFood)x))
    animal.Eat();

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

