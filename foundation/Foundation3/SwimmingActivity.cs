public class SwimmingActivity : Activity
{
    private float _laps;

    public SwimmingActivity(DateTime date, float lengthMinutes, float laps) : base(date, lengthMinutes)
    {
        _name = "Swimming";
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }

    public override float GetSpeed()
    {
        return GetDistance() / GetMinutes() * 60;
    }
}