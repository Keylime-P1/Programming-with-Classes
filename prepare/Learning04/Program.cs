using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Caleb Leonard", "Math", "7", "8-20");
        WritingAssignment write1 = new WritingAssignment("Caleb Leonard", "Writing", "Harry Potter and the time they jumped off a cliff");

        Console.WriteLine($"{math1.GetSummary()}\n{math1.GetHomeworkList()}");
        Console.WriteLine($"{write1.GetWritingInformation()}");
    }
}