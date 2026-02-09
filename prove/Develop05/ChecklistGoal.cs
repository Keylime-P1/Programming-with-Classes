public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private double _extraStars;

    public ChecklistGoal(string name, string description, double goldStars, double extraStars, int targetCount, int currentCount):base(name, description, goldStars)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _extraStars =extraStars;
    }
    public override double RecordEvent()
    {
     _currentCount++;
     if (_currentCount == _targetCount)
        {
            return _goldStars + _extraStars;
        }
        return _goldStars;
    }
    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }
    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[x]" : "[ ]";
        return $"{checkbox} {GetName()} ({GetDescription()}) -- Completed {_currentCount}/{_targetCount}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{_goldStars}|{_extraStars}|{_targetCount}|{_currentCount}";
    }
}