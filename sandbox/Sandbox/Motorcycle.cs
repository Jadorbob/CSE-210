public class Motorcycle : Vehicle
{
    private string _handlebarStyle;


    public Motorcycle(string handlebarStyle, int wheelCount, string engine) : base(wheelCount, engine)
    {
        _handlebarStyle = handlebarStyle;
    }
}