public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string serializedData) : base(serializedData)
    {
        string[] dataParts = serializedData.Split(",");

        bool.TryParse(dataParts[3], out _isComplete);
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_isComplete}";
    }
}