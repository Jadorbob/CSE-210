class Location
{
    private string _name;
    private int _distance;
    private string _description;
    private Item _loot;

    public Location(string name, int distance, string description, Item loot)
    {
        _name = name;
        _distance = distance;
        _description = description;
        _loot = loot;
    }

    public Item Visit()
    {
        Console.WriteLine($"You walk in. You are able to find: {_loot.Display()}");
        return _loot;
    }

    public void Display()
    {
        Console.WriteLine($"{_name}: {_description}");
    }
}
