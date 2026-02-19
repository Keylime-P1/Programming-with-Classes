class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing Activity",
              "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    { }

    protected override void PerformActivity()
    {
        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");
        Console.WriteLine($"--- {_prompts[_random.Next(_prompts.Count)]} ---");
        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }
}