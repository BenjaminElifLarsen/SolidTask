using SolidTask.Models.Contracts;

namespace SolidTask.Models;
public class Herbavore : Animal, IEatingFood
{
    private bool _grassedToday;

    public bool GrassedToday { get => _grassedToday; private set => _grassedToday = value; }

    protected Herbavore()
    {

    }

    public Herbavore(string name, bool isbird, string sound) : base(name, isbird)
    {
        _sound = sound;
    }

    public override void GenerateSound()
    {
        Console.WriteLine(_sound);
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
