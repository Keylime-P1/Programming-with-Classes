using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradePercent = Console.ReadLine();
        int gradePercentInt = int.Parse(gradePercent);
        if (gradePercentInt >= 90)
        {
            Console.Write("You got an A");
        }
        else if (gradePercentInt >= 80)
        {
            Console.Write("You got a B");
        }
        else if (gradePercentInt >= 70)
        {
            Console.Write("You got a C");
        }
        else if (gradePercentInt >= 60)
        {
            Console.Write("You got a D");
        }
        else
        {
            Console.Write("You got an F");
        }

        if (gradePercentInt >= 70)
        {
            Console.WriteLine(", You passed the class!");
        }
        else
        {
            Console.WriteLine(", You failed the class");
        }
        Console.WriteLine();
    }
}