class DirtBike : Motorbike
{
    public DirtBike()
    {
        _name = "Dirtbike";

    }

    public override void Ride()
    {
        Console.WriteLine("\nYour Dirtbike two stroke engine goes bumbumbumbumbumbunmbumb!");
        base.Ride();
    }
}
