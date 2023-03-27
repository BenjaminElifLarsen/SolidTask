using SolidTask.Services.Carnivore.GetAll;

namespace SolidTask.Services.Carnivore;
public partial class CarnivoreService
{

    public IEnumerable<CarnivoreListItem> All()
    {
        var list = _unitOfWork.CarnivoreRepository.All;
        return list.Select(x => new CarnivoreListItem(x));
    }
}
