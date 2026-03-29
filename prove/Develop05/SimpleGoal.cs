public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    public SimpleGoal(string name, string description, int points, int pointsEarned)
        : base(name, description, points, pointsEarned)
    {
    }

    public override void RecordEvent()
    {
        CheckMarkGoal();
        EarnPoints();
    }
}