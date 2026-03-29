public abstract class Goal
{
    private string _goalName;
    private string _description;
    private int _pointValue;
    private string _isComplete;
    private int _pointsEarned;

    // ------------------------

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _pointValue = points;
        _isComplete = " ";
        _pointsEarned = 0;
    }
    public Goal(string name, string description, int points, int pointsEarned)
    {
        _goalName = name;
        _description = description;
        _pointValue = points;
        _isComplete = " ";
        _pointsEarned = pointsEarned;
    }

    // ------------------------
    public abstract void RecordEvent();

    public void CheckMarkGoal()
    {
        _isComplete = "X";
    }

    public void EarnPoints()
    {
        _pointsEarned += _pointValue;
        Console.WriteLine($"Congrats! You got some good points!");
        Console.ReadLine();
    }

    public string IsComplete()
    {
        return _isComplete;
    }

    public string GetName()
    {
        return _goalName;
    }

    public int GetPointsEarned()
    {
        return _pointsEarned;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPointValue()
    {
        return _pointValue;
    }

    public string FileFormat()
    {
        return $"{_goalName}|{_description}|{_pointValue}";  
    }
}