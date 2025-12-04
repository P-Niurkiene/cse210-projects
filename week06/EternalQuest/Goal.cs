public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    protected Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = int.Parse(points);
    }

    public string GetShortName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetails()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {_shortName} ({_description}) worth {_points} points";
    }

    public abstract string GetRepresentation();
}
