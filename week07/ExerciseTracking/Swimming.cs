public class Swimming : Activity
{
    private int _laps;
    private const double PoolLength = 50;

    public Swimming(int laps, double minutes) : base(0, minutes)
    {
        _laps = laps;
    }

    public override string GetSummary()
    {
        double SwimDistance = (_laps * PoolLength) / 1000.0;
        double speed = (SwimDistance / _minutes) * 60;
        double pace = _minutes / SwimDistance;

        return $"Swimming - Distance: {SwimDistance:F2}km, Time: {_minutes} minutes, Speed: {speed:F2}km/hr, Pace: {pace:F2}min/km";
    }
}
