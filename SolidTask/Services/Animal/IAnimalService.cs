using SolidTask.Services.Animal.GetAll;

namespace SolidTask.Services.Animal;

public interface IAnimalService
{
    public IEnumerable<AnimalListItem> All();
}
