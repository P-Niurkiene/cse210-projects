public class CheckList : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckList(
        string shortName,
        string description,
        string points,
        int amountCompleted,
        int target,
        int bonus
    ) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetails()
    {
        return $"{base.GetDetails()} -- Currently: {_amountCompleted}/{_target}";
    }

    public override string GetRepresentation()
    {
        return $"CheckList|{GetDetails()}|Completed:{_amountCompleted}|Target:{_target}|Bonus:{_bonus}";
    }
}
