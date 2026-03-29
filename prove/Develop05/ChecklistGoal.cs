public class ChecklistGoal : Goal
{
    private int _timesNeeded;
    private int _timesCompleted;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int timesNeeded, int bonusPoints)
        : base(name, description, points)
    {
        _timesNeeded = timesNeeded;
        _timesCompleted = 0;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal(string name, string description, int points, int timesNeeded, int bonusPoints, int pointsEarned)
        : base(name, description, points, pointsEarned)
    {
        _timesNeeded = timesNeeded;
        _timesCompleted = 0;
        _bonusPoints = bonusPoints;
    }

    public int GetTimesNeeded()
    {
        return _timesNeeded;
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override void RecordEvent()
    {
        EarnPoints();
        _timesCompleted += 1;
        if (_timesCompleted >= _timesNeeded)
        {
            CheckMarkGoal();
        }
    }
}