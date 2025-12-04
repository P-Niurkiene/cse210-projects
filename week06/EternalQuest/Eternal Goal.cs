public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points)
        : base(shortName, description, points)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetRepresentation()
    {
        return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}";
    }

    public override string GetDetails()
    {
        return $"[ ] {GetShortName()} -- {GetDescription()} ({GetPoints()} pts each time)";
    }
}
