using SolidTask.Services.Carnivore.Add;
using SolidTask.Services.Carnivore.GetAll;

namespace SolidTask.Services.Carnivore;
public interface ICarnivoreService
{
    public void Add(CarnivoreRequest request);
    public IEnumerable<CarnivoreListItem> All();
}
