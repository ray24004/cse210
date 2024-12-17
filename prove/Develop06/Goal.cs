public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public Goal(string serializedData)
    {
        string[] dataParts = serializedData.Split(",");
        
        _shortName = dataParts[0];
        _description = dataParts[1];
        int.TryParse(dataParts[2], out _points);
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string check = IsComplete() ? "X" : " ";
        return $"[{check}] {_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{GetType()}:{_shortName},{_description},{_points}";
    }
}