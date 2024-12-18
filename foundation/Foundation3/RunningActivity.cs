public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(DateTime date, float lengthMinutes, float distanceKm) : base(date, lengthMinutes)
    {
        _name = "Running";
        _distance = distanceKm;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetPace()
    {
        return GetMinutes() / _distance;
    }

    public override float GetSpeed()
    {
        return _distance / GetMinutes() * 60;
    }
}