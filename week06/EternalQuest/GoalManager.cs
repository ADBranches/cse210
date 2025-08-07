using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nScore: {_score}\nMenu:\n1. Create Goal\n2. List Goals\n3. Record Event\n4. Save Goals\n5. Load Goals\n6. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.Write("Goal type (1-Simple, 2-Eternal, 3-Checklist): ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());


        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            case "4":
                Console.Write("Points to *deduct*: ");
                int points = -int.Parse(Console.ReadLine());
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        int index = int.Parse(Console.ReadLine()) - 1;
        _goals[index].RecordEvent();
        _score += _goals[index].GetPoints();  
        Console.WriteLine($"Event recorded! Score: {_score}");
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);
            _goals.Clear();

            foreach (string line in lines[1..])
            {
                string[] parts = line.Split(':');
                string type = parts[0];
                string[] data = parts[1].Split(',');

                switch (type)
                {
                    case "SimpleGoal":
                        var simpleGoal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                        simpleGoal.SetCompletionStatus(bool.Parse(data[3]));
                        _goals.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "ChecklistGoal":
                        var checklistGoal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), 
                        int.Parse(data[4]), int.Parse(data[3]));
                        checklistGoal.SetAmountCompleted(int.Parse(data[5]));
                        _goals.Add(checklistGoal);
                        break;
                }
            }
            Console.WriteLine("Goals loaded.");
        }
    }
}
