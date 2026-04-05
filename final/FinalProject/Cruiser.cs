class Cruiser : Motorbike
{
    public Cruiser()
    {
        _name = "Cruiser";

    }

    public override void Ride()
    {
        Console.WriteLine("\nYour cruiser comes to life with a smooth hum.");
        base.Ride();
    }

}
