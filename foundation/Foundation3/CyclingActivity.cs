public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(DateTime date, float lengthMinutes, float speedKph) : base(date, lengthMinutes)
    {
        _name = "Cycling";
        _speed = speedKph;
    }

    public override float GetDistance()
    {
        return _speed * GetMinutes() / 60;
    }

    public override float GetPace()
    {
        return 60 / _speed;
    }

    public override float GetSpeed()
    {
        return _speed;
    }
}