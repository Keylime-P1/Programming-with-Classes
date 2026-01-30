using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

public class Word
{
    private List<string> scriptureVerses = new List<string>();
    public void GetSharedScripture(string verse1, string verse2)
    {
        scriptureVerses.Add(verse1);
        scriptureVerses.Add(verse2);
    }
    public void ReadTest()
    {
        foreach (string verse in scriptureVerses)
        {
            Console.WriteLine(verse);
        }
    }
}