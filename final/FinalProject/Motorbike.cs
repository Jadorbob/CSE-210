abstract class Motorbike
{
    protected string _name;
    protected int _speed;
    protected int _fuel;
    protected int _health;

    protected Motorbike()
    {
    }

    public virtual void Ride()
    {
    }

    public virtual void Refuel()
    {
    }

    public virtual void Repair()
    {
    }

    public virtual void DisplayStats()
    {
    }
}
