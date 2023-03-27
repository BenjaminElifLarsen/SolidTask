namespace SolidTask.Services.Carnivore.GetAll;
using Carni = SolidTask.Models.Carnivore;
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
