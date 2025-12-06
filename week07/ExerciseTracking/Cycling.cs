public class Cycling : Activity
{
    public Cycling(double distance, double minutes) : base(distance, minutes)
    {

    }

    public override string GetSummary()
    {
        double speed = (_distance / _minutes) * 60;
        double pace = _minutes / _distance;
        return $"Cycling - Distance: {_distance}km, Time: {_minutes} minutes, Speed: {speed}km/h, Pace: {pace}min/km";
    }

    public override void DisplaySummary()
    {
        Console.WriteLine(GetSummary());
    }
}