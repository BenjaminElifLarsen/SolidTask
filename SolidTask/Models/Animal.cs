namespace SolidTask.Models;
public class Animal
{
    protected int _id;
    protected string _name;
    protected bool _isBird;

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; protected set => _name = value; }
    public bool IsBird {get => _isBird; protected set => _isBird = value; }
    protected Animal()
    {

    }

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
