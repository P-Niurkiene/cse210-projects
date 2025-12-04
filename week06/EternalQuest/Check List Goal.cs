public class CheckList : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckList(string shortName, string description, string points, int amountCompleted, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            return GetPoints() + _bonus;
        }

        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetails()
    {
        string completedMark = IsComplete() ? "[X]" : "[ ]";
        return $"{completedMark} {GetShortName()} -- {GetDescription()} " +
               $"({GetPoints()} pts each) — Progress {_amountCompleted}/{_target}";
    }

    public override string GetRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_amountCompleted},{_target},{_bonus}";
    }

}
