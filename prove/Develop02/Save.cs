using System.IO;
public class Save
{
    string fileName = "";

    public void File()
    {
        Console.WriteLine("Where would you like to save to?");
        fileName = Console.ReadLine();
        Console.WriteLine($"You are saving to {fileName}");
    }
    public void SaveEntries(Write data)
    {
        foreach (var entry in data.userEntries)
        {
            Console.WriteLine(entry);
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                outputFile.WriteLine(entry);
            }
        }
    }
    public void ClearLoad()
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                outputFile.WriteLine("");
            }
    }
    
}