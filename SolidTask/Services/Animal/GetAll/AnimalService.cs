using SolidTask.Services.Animal.GetAll;

namespace SolidTask.Services.Animal;

public partial class AnimalService : IAnimalService
{
    public IEnumerable<AnimalListItem> All()
    {
        var list = _unitOfWork.AnimalRepository.All;
        return list.Select(x => new AnimalListItem(x));
    }
}
