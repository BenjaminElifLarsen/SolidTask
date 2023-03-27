using SolidTask.Contracts;

namespace SolidTask.Models;
public class Herbavore : Animal, IEatingFood
{
    public Herbavore(string name, bool isbird) : base(name, isbird)
    {
    }

    public override void GenerateSound()
    {
        Console.WriteLine("'Plant-eating sounds'");
    }

    public override bool CanFly()
    {
        return _isBird;
    }

    public void Eat()
    {
        Console.WriteLine("Very slow nom");
    }
}
