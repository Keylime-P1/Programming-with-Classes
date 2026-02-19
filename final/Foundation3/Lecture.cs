public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture() : base()
    {
        SetEventType("Lecture");
    }
    public Lecture(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity) : base(eventTitle, description, date, time, address)
    {
        SetEventType("Lecture");
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
    public void DisplayFullDetails()
    {
        Console.WriteLine(GetEventType() + ": " + GetEventTitle() + ",");
        Console.WriteLine($"({GetDescription()})");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine($"{GetDate()} at {GetTime()}");
        GetAddress().DisplayAddress();
    }
    
}