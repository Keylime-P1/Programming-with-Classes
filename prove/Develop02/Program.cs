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

            if(option1 == 2)
            {
                journal1.DisplayEntries();
            }
        



    //     Write write1 = new Write();
    //     string readOption = "";
    //     int option1 = 0;
    //     Save save = new Save();
    //     Load load = new Load();

    //     Console.WriteLine("Welcome to the journal program!\nWould you like to:");
        
    //     while (option1 !=5)
    //     {
    //         Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
    //         readOption = Console.ReadLine();
    //         option1 = int.Parse(readOption);

    //         if (option1 == 1)
    //         {
    //             write1.NewEntry();
    //         }
    //         else if(option1 == 2)
    //         {
    //             write1.DisplayEntries();
    //         }
    //         else if(option1 == 3)
    //         {
    //             load.File(write1);
    //         }
    //         else if(option1 == 4)
    //         {
    //             save.File();
    //             save.SaveEntries(write1);
    //         }
            else
            {
                Console.WriteLine("Have a good day!");
            }
        }
    }
}