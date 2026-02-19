using System;

class Program
{
    static void Main(string[] args)
    {
        Address addy1 = new Address("6767 Meme Cir", "Idaho City", "Idaho", "United States");
        Lecture test1 = new Lecture();
        test1.SetEventTitle("Programming Class");
        test1.SetDescription("Today in class we will be learning about how to program trees. Trees are everywhere and we can program them now.");
        test1.SetDate("Friday, February 20th, 2026");
        test1.SetTime("11:30");
        test1.SetAddress(addy1);
        test1.SetSpeaker("Dr Ivo Robotnik");
        test1.SetCapacity(300);
        

        test1.DisplayShortDescription();
        Console.WriteLine();
        test1.DisplayStandardDetails();
        Console.WriteLine();
        test1.DisplayFullDetails();
        Console.WriteLine("\n\n");

        Address addy2 = new Address("1234 Addy Ln", "Farmington", "Iowa", "UnitedStates");
        Reception myReception = new Reception("Wedding", "Join us as we have a wedding for two individuals.", "06/21/2026", "2:00PM", addy2, "RSVP@gmail.com");

        myReception.DisplayShortDescription();
        Console.WriteLine();
        myReception.DisplayStandardDetails();
        Console.WriteLine();
        myReception.DisplayFullDetails();
        Console.WriteLine("\n\n");

        Address addy3 = new Address("2468 This St", "Townsville", "Texas", "UnitedStates");
        Outdoor bbq = new Outdoor("BBQ", "We havin' a bbq! Join us for food, fun and other things", "06/11/2026", "12:30PM", addy3, "sunny");
        bbq.DisplayShortDescription();
        Console.WriteLine();
        bbq.DisplayStandardDetails();
        Console.WriteLine();
        bbq.DisplayFullDetails();
        Console.WriteLine("\n\n");

        Lecture lecture2 = new Lecture("Info session", "We will be having a presentation on working at Legit Inc.", "02/23/2026", "11:30AM", addy1, "Marker Plier", 50);

        lecture2.DisplayShortDescription();
        Console.WriteLine();
        lecture2.DisplayStandardDetails();
        Console.WriteLine();
        lecture2.DisplayFullDetails();
        Console.WriteLine();
    }
}