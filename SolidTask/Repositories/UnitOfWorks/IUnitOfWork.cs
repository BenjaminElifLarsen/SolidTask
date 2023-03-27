using SolidTask.Repositories.Abstracts;

namespace SolidTask.Repositories.UnitOfWorks;
public interface IUnitOfWork
{
    public IAnimalRepository AnimalRepository { get; }
    public ICarnivoreRepository CarnivoreRepository { get; }
    public IHerbavoreRepository HerbavoreRepository { get; }
    public void Save();
}
