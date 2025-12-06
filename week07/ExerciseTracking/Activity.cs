public abstract class Activity
{
    protected double _distance { get; }
    protected double _minutes { get; }

    public Activity(double distance, double minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }

    public abstract string GetSummary();

    public virtual void DisplaySummary()
    {
        Console.WriteLine(GetSummary());
    }
}