using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string userNumString;
        int userNum = 1;
        int numTotal = 0;
        int numAverage = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNum != 0)
        {
            Console.Write("Enter a number: ");
            userNumString = Console.ReadLine();
            userNum = int.Parse(userNumString);
            if (userNum  !=0)
            {
                numbers.Add(userNum);
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numTotal = numTotal + numbers[i];
                }
                numAverage = numTotal / numbers.Count;
                Console.WriteLine($"Your sum is {numTotal}");
                Console.WriteLine($"Your average is {numAverage}");
            }
        }
    }
}