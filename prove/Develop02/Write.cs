using System.Security.Cryptography.X509Certificates;

public class Write
{
    string[] promptList = {"What is something that made you happy today? ", "Who is someone you are thankful for? ", "What was something that was hard today? ", "What was something you tried to imporve on today? "};
    public List<string> userEntries = new List<string>{};
    public List<string> loadedEntries = new List<string>{};
    public void NewEntry()
    {
        Random random = new Random();
        int randomNum = random.Next(0, 4);
        Console.Write(promptList[randomNum]);
        string userEntry = Console.ReadLine();

        userEntries.Add(userEntry);
    }
    public void DisplayEntries()
    {
        foreach (string entry in loadedEntries)
        {
            Console.WriteLine($"\n{entry}\n");
        }
        foreach ( string entry in userEntries)
        {
            Console.WriteLine($"\n{entry}\n");
        }
    }
}