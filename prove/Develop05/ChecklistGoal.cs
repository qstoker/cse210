public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points) { }

    public override void RecordEvent() { }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}
