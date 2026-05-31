using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

public class Word
{
    private string _word;
    private int _wordCount;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
    }
    public void Display()
    {
        if (_isHidden == true)
        {
            _wordCount = _word.Length;
            for (int i = 0; i < _wordCount; i++)
            {
                Console.Write("-");
            }
            Console.Write(" ");
        }
        else
        {
            Console.Write(_word + " ");
        }
    }
    public void Hide()
    {
        _isHidden = true;
    }
    
}