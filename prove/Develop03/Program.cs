using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //Initialize the classes
        Reference r1 = new Reference();
        Scripture s1 = new Scripture();
        Word w1 = new Word();

        // Console.WriteLine(r1.GetReferenceBook());
        // Console.WriteLine(r1.GetReferenceChapter());
        // Console.WriteLine(r1.GetReferenceStartVerse());
        // Console.WriteLine(r1.GetReferenceEndVerse());
        // r1.SetReferenceBook("Psalms");
        // r1.SetReferenceChapter(1);
        // r1.SetReferenceStartVerse(1);
        // r1.SetReferenceEndVerse(2);
        // Console.WriteLine(r1.GetReferenceBook());
        // Console.WriteLine(r1.GetReferenceChapter());
        // Console.WriteLine(r1.GetReferenceStartVerse());
        // Console.WriteLine(r1.GetReferenceEndVerse());
        // s1.GetScriptureVerse(r1.GetReferenceBook(), r1.GetReferenceChapter(), r1.GetReferenceStartVerse(), r1.GetReferenceEndVerse());

        //Call upon Reference class and request desired scriptures
        Reference r2 = new Reference("John", 3, 5, 7);
        //Test to determine functionality of initialization
        Console.WriteLine(r2.GetReferenceBook());
        Console.WriteLine(r2.GetReferenceChapter());
        Console.WriteLine(r2.GetReferenceStartVerse());
        Console.WriteLine(r2.GetReferenceEndVerse());
        //Call Scripture class with values from our Reference above and search for scripture verses
        s1.GetScriptureVerse(r2.GetReferenceBook(), r2.GetReferenceChapter(), r2.GetReferenceStartVerse(), r2.GetReferenceEndVerse());
        //Send retrieved verses to Word class to start the study session
        w1.GetSharedScripture(s1.ShareScriptureVerse1(), s1.ShareScriptureVerse2());
        w1.ReadTest();

    }
}