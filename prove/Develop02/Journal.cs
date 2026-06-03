public class Journal
{
    
    private string _fileName;
    private List<string[]> _userEntries = new List<string[]>{};

    public void GetEntries(string[] userEntries)
    {
        _userEntries.Add(userEntries);
    }
    public void DisplayEntries()
    {
        for(int i = 0; i <_userEntries.Count; i++)
        {
            Console.WriteLine($"Date: {_userEntries[i][3]}, -Prompt: {_userEntries[i][1]}, Entry: {_userEntries[i][2]}");
        }
    }
}