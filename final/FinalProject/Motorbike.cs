abstract class Motorbike
{
    protected string _name;
    protected int _health;
    protected bool _isAlive;

    protected Motorbike()
    {
        _name = "The ThundarBike!!";
        _health = 100;
        _isAlive = true;
    }

    public virtual void Ride()
    {
        _health -= 20;
    }

    public virtual void Repair()
    {
        _health += 50;
    }

    public int ShowBikeHealth()
    {
        return _health;
    }

    public bool IsAlive() 
    {
        if (_health <= 0)
        {
            _isAlive = false;
        }
        
        return _isAlive;
    }
}
