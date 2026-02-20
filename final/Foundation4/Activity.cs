public class Activity
{
    private DateTime _date;
    private int _minutes;
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
    public virtual double GetPace()
    {
        return _minutes / GetDistance();
    }
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_minutes} min) - " + 
        $"Distance {GetDistance():0.00} km, " + 
        $"Speed {GetSpeed():0.00} kph, " + 
        $"Pace: {GetPace():0.00} min per km";
    }
}