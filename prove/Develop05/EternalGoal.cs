public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        
    }
    public EternalGoal(string name, string description, int points, int pointsEarned)
        : base(name, description, points, pointsEarned)
    {
        
    }

    public override void RecordEvent()
    {
        EarnPoints();
    }
}