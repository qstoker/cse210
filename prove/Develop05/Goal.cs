public abstract class Goal
{
    string _shortName;
    string _description;
    string _points;

    public Goal(string name, string description, string points) { }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();
}
