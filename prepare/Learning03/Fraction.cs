public class Fraction
{
    // Attributes
    private int _top;
    private int _bottom;

// ------------------------------------
// Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int a, int b)
    {
        _top = a;
        _bottom = b;
    }
    public Fraction(int a)
    {
        _top = a;
        _bottom = 1;
    }

// -------------------------------------
    // Methods

    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int a)
    {
        _top = a;
    }

    public void SetBottom(int a)
    {
        _bottom = a;
    }
// -------------------------------------
    public string GetFractionString()
    {
        return $"Top: {_top} : Bottom: {_bottom}";
    }
    public double GetDecimal()
    {
        return _top / _bottom;
    }
}