public class Journal
{
    
    private string _fileName;
    private string _loadFile;
    private string _fileStore;
    private List<string[]> _userEntries = new List<string[]>{};

    public void GetEntries(string[] userEntries)
    {
        _userEntries.Add(userEntries);
    }
    public void DisplayEntries()
    {
        for(int i = 0; i <_userEntries.Count(); i++)
        {
            Console.WriteLine($"Date: {_userEntries[i][0]}, -Prompt: {_userEntries[i][1]}, Entry: {_userEntries[i][2]}");
        }
    }
    public void SaveEntries()
    {
        Console.WriteLine("Where would you like to save to?");
        _fileName = Console.ReadLine();
        Console.WriteLine($"You are saving to {_fileName}");

        for (int i = 0; i< _userEntries.Count(); i++)
        {
            using(StreamWriter outputFile = new StreamWriter(_fileName, true))
            {
                outputFile.WriteLine($"Date:{_userEntries[i][0]}|{_userEntries[i][1]}|{_userEntries[i][2]}");
            }
        }
        File.WriteAllLines(_fileName, File.ReadAllLines(_fileName).Where(line => !string.IsNullOrWhiteSpace(line)));
        
    }
    public void LoadEntries()
    {
        Console.WriteLine("What file would you like to view?: ");
        _loadFile = Console.ReadLine();
        _fileStore = File.ReadAllText(_loadFile);
        Console.WriteLine(_fileStore);
        _userEntries.Clear();
         using(StreamWriter clearFile = new StreamWriter(_loadFile,false))
            {
                clearFile.WriteLine();
            }
        
         string[] _fileSplit = _fileStore.Split("Date:");
         _fileSplit = _fileSplit.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
        foreach (var words in _fileSplit)
        {
            Console.WriteLine(words);
        }
        Console.WriteLine(_fileSplit[1]);
        for (int i = 0; i < _fileSplit.Length; i++)
        {
            string[] entrySplit = _fileSplit[i].Split("|");
            entrySplit = entrySplit.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
            for (int j = 0; j < entrySplit.Length; j++)
            {
                Console.WriteLine(entrySplit[j]);
                
            }
             _userEntries.Add(entrySplit);   
        }
        
    }
}