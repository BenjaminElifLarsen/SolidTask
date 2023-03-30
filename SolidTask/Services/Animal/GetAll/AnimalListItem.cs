using Ani = SolidTask.Models.Animal;
namespace SolidTask.Services.Animal.GetAll;

public class AnimalListItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Sound { get; set; }

    public AnimalListItem(Ani animal)
    {
        Id = animal.Id;
        Name = animal.Name;
        Sound = animal.Sound;
    }
}
