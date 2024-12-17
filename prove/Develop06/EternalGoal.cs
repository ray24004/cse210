public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public EternalGoal(string serializedData) : base(serializedData)
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}