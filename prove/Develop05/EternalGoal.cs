public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, double goldStars) : base(name, description, goldStars)
    {

    }
    public override double RecordEvent()
    {
        return _goldStars;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
    public override string GetStringRepresentation()
    {
        return $"Eternal goal|{GetName()}|{GetDescription}|{_goldStars}";
    }
}