
using SolidTask.Services.Herbavore.GetAll;

namespace SolidTask.Services.Herbavore;
public partial class HerbavoreService
{

    public IEnumerable<HerbavoreListItem> All()
    {
        var list = _unitOfWork.HerbavoreRepository.All;
        return list.Select(x => new HerbavoreListItem(x));
    }
}
