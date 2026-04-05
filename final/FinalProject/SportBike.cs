class SportBike : Motorbike
{
    public SportBike()
    {
        _name = "SportBike";
    }

    public override void Ride()
    {
        Console.WriteLine("\nYour sport bike blasts forward with a loud roar.");
        base.Ride();
    }
}
