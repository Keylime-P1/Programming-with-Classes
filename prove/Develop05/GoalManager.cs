using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private double _goldStarsEarned = 0;

    void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Description: ");
        string description = Console.ReadLine();
        Console.Write("Gold Stars: ");
        double goldStars = double.Parse(Console.ReadLine());

        if (type == "1")
            {
                _goals.Add(new SimpleGoal(name, description, goldStars));
            }
        else if (type == "2")
            {
                _goals.Add(new EternalGoal(name, description, goldStars));
            }
            else
            {
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus Gold Stars: ");
                double bonus = double.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, goldStars, bonus, target, 0));
            }
    }
    void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        double earned = _goals[index].RecordEvent();
        _goldStarsEarned += earned;

        Console.WriteLine($"You Earned {earned} million gold stars!");
    }
    void SaveGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_goldStarsEarned);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    void LoadGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);
        _goldStarsEarned = double.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            switch (parts[0])
            {
                case "SimpleGoal":
                _goals.Add(new SimpleGoal(parts[1], parts[2], double.Parse(parts[3]), bool.Parse(parts[4])));
                break;

                case "EternalGoal":
                _goals.Add(new EternalGoal(parts[1], parts[2], double.Parse(parts[3])));
                break;

                case "ChecklistGoal":
                _goals.Add(new ChecklistGoal(parts[1], parts[2], double.Parse(parts[3]), double.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                break;
            }
        }
    }
    public void Start()
    {
        string option = "";
        while (option != "6")
        {
            Console.WriteLine($"\nYou have {_goldStarsEarned} million gold stars.");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            option = Console.ReadLine();

            switch (option)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
            }
        }
    }
}

