using System.Formats.Tar;

public class ChecklistGoal : Goal
{
    private int _amountcompleted;
    private int _targetAmount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountcompleted = 0;
        _targetAmount = target;
        _bonusPoints = bonus;
    }

    public ChecklistGoal(string serializedData) : base(serializedData)
    {
        string[] dataParts = serializedData.Split(",");

        int.TryParse(dataParts[3], out _bonusPoints);
        int.TryParse(dataParts[4], out _targetAmount);
        int.TryParse(dataParts[5], out _amountcompleted);
    }

    public override bool IsComplete()
    {
        return _amountcompleted >= _targetAmount;
    }

    public override void RecordEvent()
    {
        if(_amountcompleted < _targetAmount)
        {
            _amountcompleted++;
        }
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Currently completed: {_amountcompleted}/{_targetAmount}";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_bonusPoints},{_targetAmount},{_amountcompleted}";
    }
}