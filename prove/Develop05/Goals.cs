public abstract class Goal
{
    protected double _goldStars;
    private string _name;
    private string _description;

    public Goal(string name, string description, double goldStars)
    {
        _name = name;
        _description = description;
        _goldStars = goldStars;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public abstract bool IsComplete();
    public abstract double RecordEvent();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}