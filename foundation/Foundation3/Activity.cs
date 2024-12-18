public abstract class Activity
{
    protected string _name;
    private DateTime _date;
    private float _minutes;

    public Activity(DateTime date, float minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected float GetMinutes()
    {
        return _minutes;
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {_name} ({_minutes:00} min) - Distance: {GetDistance():.0} km, Speed: {GetSpeed():.0} kph, Pace: {GetPace():.00} min per km";
    }
}