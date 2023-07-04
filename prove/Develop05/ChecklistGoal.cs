public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int amountCompleted,
        int target,
        int bonus
    )
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent() // originally void...
    {
        if (_amountCompleted + 1 < _target)
        {
            _amountCompleted++;
            return _points;
        }
        else if (_amountCompleted < _target)
        {
            _amountCompleted++;
            return _points + _bonus;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _target)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
