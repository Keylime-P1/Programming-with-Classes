using System;
class Program
{
    static void Main(string[] args)
    {
        Entry entry1 = new Entry();
        Journal journal1 = new Journal();
        string readOption = "";
        int option1 = 0;

        Console.WriteLine("Welcome to the journal program!\nWould you like to:");
        
        while (option1 !=5)
        {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            readOption = Console.ReadLine();
            option1 = int.Parse(readOption);
            
            if(option1 == 1)
            {
                entry1.NewEntry();
                journal1.GetEntries(entry1.GetEntry());
            }
            else if(option1 == 2)
            {
                journal1.DisplayEntries();
            }
            else if(option1 == 3)
            {
                journal1.LoadEntries();
            }
            else if(option1 == 4)
            {
                journal1.SaveEntries();
            }
            else
            {
                Console.WriteLine("Have a good day!");
            }
        }
    }
}