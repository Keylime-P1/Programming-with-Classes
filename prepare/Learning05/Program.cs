using System;

class Program
{
    static void Main(string[] args)
    {
        Square greg = new Square("Yellow", 4);
        Console.WriteLine(greg.GetColor());
        Console.WriteLine(greg.GetArea());
        greg.SetColor("Green");
        Console.WriteLine(greg.GetColor());

    }
}