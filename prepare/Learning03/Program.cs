using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction1 = new Fraction();
        Fraction myFraction2 = new Fraction(4);
        Fraction myFraction3 = new Fraction(2,3);
        
        Console.WriteLine("Initialized values:");
        Console.WriteLine($"{myFraction1.GetTop()}, {myFraction2.GetTop()}, {myFraction3.GetTop()} ");
        Console.WriteLine($"{myFraction1.GetBottom()}, {myFraction2.GetBottom()}, {myFraction3.GetBottom()} ");
        
        Console.Write("\nSet new top value:");
        string newTopString = Console.ReadLine();
        int newTop = int.Parse(newTopString);
        myFraction1.SetTop(newTop);

        Console.Write("Set new bottom value:");
        string newBottomString = Console.ReadLine();
        int newBottom = int.Parse(newBottomString);
        myFraction1.SetBottom(newBottom);

        Console.WriteLine($"\nNew top value: {myFraction1.GetTop()}\nNew bottom value: {myFraction1.GetBottom()}");
        double mydecimal; 

        Console.WriteLine("fraction methods test");
        Console.WriteLine(myFraction1.GetFractionString());
        mydecimal = myFraction1.GetDecimalValue();
        Console.WriteLine(mydecimal);
        
    }
}