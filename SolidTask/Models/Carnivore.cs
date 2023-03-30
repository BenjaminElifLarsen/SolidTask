using SolidTask.Models.Contracts;

namespace SolidTask.Models;
public class Carnivore : Animal, IEatingFood, IHuntingFood, ITrackingFood
{
    private bool _eatenFoodToday;

    public bool EatenFoodToday { get => _eatenFoodToday; private set => _eatenFoodToday = value; }

    protected Carnivore()
    {

    }

    public Carnivore(string name, bool isbird) : base(name, isbird)
    {
    }

    public override void GenerateSound()
    {
        Console.WriteLine("'Meat-eating sounds'");
    }

    public override bool CanFly()
    {
        return _isBird;
    }

    public void Eat()
    {
        Console.WriteLine("Nom");
    }

    public void Hunt()
    {
        Console.WriteLine("Sneaking very slowly...");
    }

    public void Track()
    {
        Console.WriteLine("Someone taken a step here");
    }
}
