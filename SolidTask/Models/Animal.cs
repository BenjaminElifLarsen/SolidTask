namespace SolidTask.Models;
public class Animal
{
    protected string _name;
    protected bool _isBird;

    public string Name => _name;

    public Animal(string name, bool isBird)
    {
        _name = name;
        _isBird = isBird;
    }

    public virtual void GenerateSound()
    {
        Console.WriteLine("...");
    }

    public virtual bool CanFly()
    {
        return _isBird;
    }
}
