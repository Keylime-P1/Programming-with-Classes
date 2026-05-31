using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //Initialize the classes
        Reference r1 = new Reference();
        Scripture s1 = new Scripture();

        //Call upon Reference class and request desired scriptures
        Reference r2 = new Reference("John", 3, 5, 7);
        Console.Clear();
        //Test to determine functionality of initialization
        Console.Write(r2.GetReferenceBook() + " ");
        Console.Write(r2.GetReferenceChapter() + ":");
        Console.Write(r2.GetReferenceStartVerse() + "-");
        Console.WriteLine(r2.GetReferenceEndVerse());
        //Call Scripture class with values from our Reference above and search for scripture verses
        s1.GetScriptureVerse(r2.GetReferenceBook(), r2.GetReferenceChapter(), r2.GetReferenceStartVerse(), r2.GetReferenceEndVerse());
        //Send retrieved verses to Word class to start the study session
       string[] wordsPrimitave = s1.ShareScriptureVerse1().Split(' ');
       string[] wordsPrimitave1 = s1.ShareScriptureVerse2().Split(' ');
       List<Word> words = new List<Word>();

       for(int i = 0; i < wordsPrimitave.Length; i++)
        {
            words.Add(new Word(wordsPrimitave[i]));
        }
        for(int i = 0; i < wordsPrimitave1.Length; i++)
        {
            words.Add(new Word(wordsPrimitave1[i]));
        }

        for (int i = 0; i < words.Count; i++)
        {
            words[i].Display();
        }
        
        for (int i = 0; i < words.Count; i++){
            Console.WriteLine();
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            words[i].Hide();
            Console.Clear();

            r2.DisplayReference();
            for (int j = 0; j < words.Count; j++)
            {
                words[j].Display();
            }
        }
        Console.Clear();
        Console.WriteLine("You've completed the verses!\n");
    }
}