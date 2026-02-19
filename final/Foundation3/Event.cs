public class Event
{
    private string _eventType;
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public Event()
    {
        
    }
    public Event( string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetEventType()
    {
        return _eventType;
    }
    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetEventType(string eventType)
    {
        _eventType = eventType;
    }
    public void SetEventTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public void DisplayStandardDetails()
    {
        Console.WriteLine(_eventTitle + ",");
        Console.WriteLine($"({_description})");
        Console.WriteLine($"{_date} at {_time}");
        _address.DisplayAddress();
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine(_eventType + ", " + _eventTitle + ", " + _date);
        
    } 
}