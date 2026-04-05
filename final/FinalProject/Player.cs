class Player
{
    private Motorbike _playerBike;
    private Inventory _inventory;
    private bool _isAlive;
    private int _health;

    public Player(Motorbike bike, Inventory inventory)
    {
        _playerBike = bike;
        _inventory = inventory;
        _isAlive = true;
        _health = 100;
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Your Health is at {_health}");
        Console.WriteLine($"Your Motorbikes health is at {_playerBike.ShowBikeHealth()}");

        Console.WriteLine("\nInventory: ");
        _inventory.ShowItems();
    }


    public bool IsAlive() 
    {
        if (_health <= 0)
        {
            _isAlive = false;
        }
        
        return _isAlive;
    }

    public void Heal()
    {
        _health += 50;
    }
}
