using Carni = SolidTask.Models.Carnivore;
namespace SolidTask.Services.Carnivore.GetAll;
public class CarnivoreListItem
{
    public int Id { get; }
    public string Name { get; }
    public bool Bird { get; }

    public CarnivoreListItem(Carni carni)
    {
        Id = carni.Id;
        Name = carni.Name;
        Bird = carni.IsBird;
    }
}
