public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, double goldStars, bool isComplete = false) : base(name, description, goldStars)
    {
        _isComplete = isComplete;
    }
    public override double RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _goldStars;
        }
        return 0;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{_goldStars}|{_isComplete}";
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[x]": "[ ]";
        return $"{checkbox}|{GetName()}|({GetDescription()})";
    }
}