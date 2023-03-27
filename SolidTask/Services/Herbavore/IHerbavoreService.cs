using SolidTask.Services.Herbavore.Add;
using SolidTask.Services.Herbavore.GetAll;

namespace SolidTask.Services.Herbavore;
public interface IHerbavoreService
{
    public void Add(HerbavoreRequest request);
    public IEnumerable<HerbavoreListItem> All();
}
