public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public virtual void RecordEvent()
    {

    }
    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetails()
    {
        return $"{_shortName}, {_description}, Points: {_points}";
    }
    public abstract string GetRepresentation();
}