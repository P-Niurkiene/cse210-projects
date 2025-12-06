using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;

public class Running : Activity
{
    public Running(double distance, double minutes) : base(distance, minutes)
    {

    }

    public override string GetSummary()
    {
        double speed = (_distance / _minutes) * 60;
        double pace = _minutes / _distance;
        return $"Running - Distance: {_distance}km, Time: {_minutes} minutes, Speed: {speed}km/h, Pace: {pace}min/km";
    }

    public override void DisplaySummary()
    {
        Console.WriteLine(GetSummary());
    }
}