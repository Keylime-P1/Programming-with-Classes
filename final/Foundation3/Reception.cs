public class Reception : Event
{
    private string _register;
    public Reception() : base()
    {
        SetEventType("Reception");
    }
    public Reception(string eventTitle, string description, string date, string time, Address address, string register) : base(eventTitle, description, date, time, address)
    {
        SetEventType("Reception");
        _register = register;
    }
    public string GetRegister()
    {
        return _register;
    }
    public void SetRegister(string register)
    {
        _register = register;
    }
    public void DisplayFullDetails()
    {
        Console.WriteLine(GetEventType() + ": " + GetEventTitle() + ",");
        Console.WriteLine($"({GetDescription()})");
        Console.WriteLine($"RSVP: {GetRegister()}");
        Console.WriteLine($"{GetDate()} at {GetTime()}");
        GetAddress().DisplayAddress();
    }
}