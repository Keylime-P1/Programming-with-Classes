using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromtUserName()
    {
        Console.Write("What is your name?: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        string userNumString = Console.ReadLine();
        int userNumInt = int.Parse(userNumString);
        return userNumInt;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("What is the year you were born?: ");
        string userYearString = Console.ReadLine();
        birthYear = int.Parse(userYearString);
    }
    static int SquareNumber(int number)
    {
        int numSquared = number*number;
        return numSquared;
    }
    static void DisplayResult(string userName, int birthYear, int numberSquared)
    {
        int currentYear = 2026;
        int userAge = currentYear - birthYear;
        Console.WriteLine($"\nHello {userName}, the square of your number is {numberSquared}.\nYou will turn {userAge} this year. ");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromtUserName();
        int userNumber = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(userName, birthYear, numberSquared);

    }
}