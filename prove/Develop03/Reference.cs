using Microsoft.VisualBasic;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    //Use method to call the dictionary in Scripture for specific verses
    public Reference()
    {
        _book = "";
        _chapter = 0;
        _startVerse = 0;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public void SetReferenceBook(string book)
    {
        _book = book;
    }
    public void SetReferenceChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetReferenceStartVerse(int startVerse)
    {
        _startVerse = startVerse;
    }
    public void SetReferenceEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
    public string GetReferenceBook()
    {
        return _book;
    }
    public int GetReferenceChapter()
    {
        return _chapter;
    }
    public int GetReferenceStartVerse()
    {
        return _startVerse;
    }
    public int GetReferenceEndVerse()
    {
        return _endVerse;
    }
}