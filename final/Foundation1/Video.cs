using System.Reflection;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments = new List<Comments>();
    public Video()
    {
        
    }
    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _length = videoLength;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public void SetLength(int videoLength)
    {
        _length = videoLength;
    }
    public void DisplayVideo()
    {
        Console.WriteLine(GetTitle());
        Console.WriteLine(GetAuthor());
        Console.WriteLine(GetLength());
        // Console.WriteLine();
    }
    public void AddComment(Comments comment)
    {
        _comments.Add(comment);
    }
    public void DisplayComments()
    {
        foreach (Comments newcomment in _comments)
        {
            Console.Write(newcomment.GetName());
            Console.WriteLine($": {newcomment.GetComment()}");
        }
        Console.WriteLine();
    }
}