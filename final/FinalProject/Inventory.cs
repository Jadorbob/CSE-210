class Inventory
{
    private List<Item> _items = new List<Item>();

    public Inventory()
    {
        Item Medkit = new Item("Medkit", 1);
        Item Repairkit = new Item("Repairkit", 2);
        _items.Add(Medkit);
        _items.Add(Repairkit);
    }

    public void AddItem(Item item)
    {
    }

    public void UseItem()
    {
        Console.WriteLine("Which Item would you like to use?");
        ShowItems();
        Console.WriteLine("For Medkit press 1");
        Console.WriteLine("For Repairkit press 2");
    }

    public void ShowItems()
    {
        foreach (Item item in _items)
        {
            item.Display();
        }
    }
}
