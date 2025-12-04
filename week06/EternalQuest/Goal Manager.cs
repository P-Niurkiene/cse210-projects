using System.ComponentModel;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(int score)
    {
        _score = score;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            DisplayInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. List Goal Names");
            Console.WriteLine("2. List Goal Details");
            Console.WriteLine("3. Create a New Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.WriteLine("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListGoalNames();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoal();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invaild Choice, please selcet a number between 1 and 7.");
                    break;

            }


        }



    }
    public void DisplayInfo()
    {
        int sweetTreat = 1000 - _score;
        if (_score >= 1000)
        {
            Console.WriteLine("Wow you got 1000 points! Reward yourself with a sweet treat!");
            _score = 0;
        }
        else
        {
            Console.WriteLine($"Your current score is {_score}, you are {sweetTreat} away from a Sweet Treat!");
        }

    }
    public void ListGoalNames()
    {
        Console.WriteLine("Your Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"- {goal.GetDetails()}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetRepresentation());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("What kind of goal would you like to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Check List Goal");
        Console.Write("Please enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Short name: ");
                string name1 = Console.ReadLine();
                Console.Write("Description: ");
                string desc1 = Console.ReadLine();
                Console.Write("Points: ");
                string points1 = Console.ReadLine();

                _goals.Add(new SimpleGoal(name1, desc1, points1));
                break;

            case "2":
                Console.Write("Short name: ");
                string name2 = Console.ReadLine();
                Console.Write("Description: ");
                string desc2 = Console.ReadLine();
                Console.Write("Points: ");
                string points2 = Console.ReadLine();

                _goals.Add(new EternalGoal(name2, desc2, points2));
                break;

            case "3":
                Console.Write("Short name: ");
                string name3 = Console.ReadLine();
                Console.Write("Description: ");
                string desc3 = Console.ReadLine();
                Console.Write("Points: ");
                string points3 = Console.ReadLine();
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new CheckList(name3, desc3, points3, 0, target, bonus));
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }

        Console.Write("Enter the goal number: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        int points = _goals[choice].RecordEvent();

        _score += points;

        Console.WriteLine($"Congratulations! You gained {points} points!");
    }


    public void SaveGoal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        List<string> lines = new List<string>
    {
        _score.ToString()
    };

        foreach (Goal goal in _goals)
        {
            lines.Add(goal.GetRepresentation());
        }

        File.WriteAllLines(filename, lines);
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(data[0], data[1], data[2], bool.Parse(data[3])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], data[2]));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new CheckList(data[0], data[1], data[2], int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])
                ));
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }
}

