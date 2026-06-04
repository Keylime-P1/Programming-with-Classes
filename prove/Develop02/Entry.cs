using System.Net.Mail;

public class Entry
{
    string[] promptList = {"What is something that made you happy today?", "Who is someone you are thankful for?", "What was something that was hard today?", "What was something you tried to improve on today?"};
    private string _userEntry;
    private string _prompt;
    private DateTime _date = DateTime.Today;

    private string GetPrompt()
    {
        Random random = new Random();
        int randomNum = random.Next(0, 4);
        _prompt = promptList[randomNum];

        return _prompt;
    }

    public void NewEntry()
    {
        GetPrompt();
        Console.WriteLine(_prompt);
        _userEntry = Console.ReadLine();
    }
    public string[] GetEntry()
    {
        string[] entry = {_date.ToString("yyyy-MM-dd"), _prompt, _userEntry};
        return entry;
    }
}