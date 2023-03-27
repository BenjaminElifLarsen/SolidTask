namespace SolidTask.Services.Herbavore.GetAll;
using Herba = SolidTask.Models.Herbavore;
public class HerbavoreListItem
{
    public int Id { get; }
    public string Name { get; }
    public bool Bird { get; }

    public HerbavoreListItem(Herba herbavore)
    {
        Id = herbavore.Id;
        Name = herbavore.Name;
        Bird = herbavore.IsBird;
    }
}
