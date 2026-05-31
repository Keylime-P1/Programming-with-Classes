using System.Collections.Concurrent;

public class Scripture
{
    //Use dictionary to store scriptures
    private string _scriptureVerse1;
    private string _scriptureVerse2;
    private Dictionary<string, Dictionary<int, Dictionary<int, string>>> scriptures = new Dictionary<string, Dictionary<int, Dictionary<int, string>>>()
    {
      {"John", new Dictionary<int, Dictionary<int, string>>()
        {
            {3, new Dictionary<int, string>()
                {
                    {5, "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God."},
                    {6, "This is definitely John 3:6"},
                    {7, "Marvel not that I said unto thee, Ye must be born again."},
                }
            },
            {4, new Dictionary<int, string>()
            {
                {1,"This is definitely John 4:1"},
                {2, "This is totally John 4:2"},
            }
            },
        }
      },
      {"Psalms", new Dictionary<int, Dictionary<int, string>>()
      {
          {1, new Dictionary<int, string>()
          {
              {1, "This is definitely psalms 1:1"},
              {2, "This is totally Psalms 1:2"},
          }
          },
          {2, new Dictionary<int, string>()
          {
              {1, "This is definitely Psalms 2:1"},
              {2, "This is definitely Psalms 2:2"},
          }
          }
      }
      }
    };

    public void GetScriptureVerse(string book, int chapter, int startVerse, int endVerse)
    {
        var scriptureVerse1 = scriptures[book][chapter][startVerse];
        var scriptureVerse2 = scriptures[book][chapter][endVerse];
        // Console.WriteLine(scriptureVerse1 + " " + scriptureVerse2);

        _scriptureVerse1 = scriptureVerse1;
        _scriptureVerse2 = scriptureVerse2;
    }
    public string ShareScriptureVerse1()
    {
        return _scriptureVerse1;
    }
    public string ShareScriptureVerse2()
    {
        return _scriptureVerse2;
    }
}