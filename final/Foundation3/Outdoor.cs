public class Outdoor : Event
{
    private string _weather;
    public Outdoor() : base()
    {
        SetEventType("Outdoor");
    }
    public Outdoor(string eventTitle, string description, string date, string time, Address address, string weather) : base(eventTitle, description, date, time, address)
    {
        SetEventType("Outdoor");
        _weather = weather;
    }
    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }
    public void DisplayFullDetails()
    {
        Console.WriteLine(GetEventType() + ": " + GetEventTitle() + ",");
        Console.WriteLine($"({GetDescription()})");
        Console.WriteLine($"Weather: {GetWeather()}");
        Console.WriteLine($"{GetDate()} at {GetTime()}");
        GetAddress().DisplayAddress();
    }
}