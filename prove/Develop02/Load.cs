public class Load
{
    string fileName = "";
    public void File(Write data)
    {
        Console.WriteLine("What file would you like to edit? ");
        fileName = Console.ReadLine();
        string[] testRead = System.IO.File.ReadAllLines(fileName);
        foreach (string entry in testRead)
        {
            Console.WriteLine(entry);
            data.loadedEntries.Add(entry);
        }
    }
}