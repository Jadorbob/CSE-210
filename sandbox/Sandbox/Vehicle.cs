public class Vehicle
{
    private int _wheelCount;
    private string _engine;

    public Vehicle(int wheelCount)
    {
        _wheelCount = wheelCount;
        _engine = "UNKNOWN";
    }
    public Vehicle(int wheelCount, string engine)
    {
        _wheelCount = wheelCount;
        _engine = engine;
    }

    public string GetEngineType()
    {
        return _engine;
    }

    public string GetEngineType(int _wheelCount)
    {
        return _engine;
    }
}