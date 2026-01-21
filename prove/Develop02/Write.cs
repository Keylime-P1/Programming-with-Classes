using System.Security.Cryptography.X509Certificates;

public class Write
{
    string[] promptList = {"test the thing 1 ", "test the thing 2 ", "test the thing 3 ", "test the thing 4 "};
    public List<string> userEntries = new List<string>{};
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
        foreach ( string entry in userEntries)
        {
            Console.WriteLine($"\n{entry}\n");
        }
    }
}