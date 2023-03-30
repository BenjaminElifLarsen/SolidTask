namespace SolidTask.Models;
public abstract class Animal
{
    protected int _id;
    protected string _name;
    protected bool _isBird;
    protected string _sound = "...";
    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; protected set => _name = value; }
    public bool IsBird {get => _isBird; protected set => _isBird = value; }
    public string Sound { get => _sound; protected set => _sound = value; }
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
        Console.WriteLine(_sound);
    }

    public virtual bool CanFly()
    {
        return _isBird;
    }
}
