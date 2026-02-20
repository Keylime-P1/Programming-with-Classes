using System;

class Program
{
        static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2026, 02, 27), 30, 5.2));
        activities.Add(new Biking(new DateTime(2026, 06, 22), 60, 23));
        activities.Add(new Swimming(new DateTime(2026, 07, 13), 45, 17));

        foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
    }
    
}