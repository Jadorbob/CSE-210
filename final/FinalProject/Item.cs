class Item
{
    private string _name;
    private int _type;

    public Item(string name, int type)
    {
        _name = name;
        _type = type;
    }

    public void UseItem(Player player, Motorbike bike)
    {
        if (_type == 1)
        {
            player.Heal();
        }

        if (_type == 2)
        {
            bike.Repair();
        }
    }

    public string Display()
    {
        return _name;
    }
}
