// Showing Creativity and Exceeding Requirements: I decided to make an extra class for those goals that needs discipline thru the time, 
// this class as the other 3 Goal classes inherit part of its behavior from the base Goal class, adapting some of them to its own needs.
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("Goals: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details: ");
        foreach (Goal g in _goals)
        {
            string checkbox = g.IsComplete() ? "[X]" : "[ ]";

            if (g is CheckListGoal checkList)
            {
                Console.WriteLine($"{checkbox} {checkList.GetShortName()} ({checkList.GetDescription()}) -- Completed {checkList.GetAmountCompleted()}/{checkList.GetTarget()}");
            }
            else
            {
                Console.WriteLine($"{checkbox} {g.GetDetailsString()}");
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Discipline Goal");
        string choice = Console.ReadLine();

        Console.WriteLine("What is the name of your Goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associeted with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplish for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing this goal that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new CheckListGoal(name, description, points, target, bonus));
        }
        else if (choice == "4")
        {
            Console.Write("Enter target duration (in days): ");
            int targetDuration = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing this goal for that period of time?");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new DisciplineGoal(name, description, points, targetDuration, bonus));
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Select a goal to record: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];

            selectedGoal.RecordEvent();

            _score += selectedGoal.GetPoints();

            if (selectedGoal is CheckListGoal checkList && checkList.IsComplete())
            {
                _score += checkList.GetPoints();
                Console.WriteLine($"Bonus awarded! Your total score is now {_score}.");
            }
            else
            {
                Console.WriteLine($"Your total score is now {_score}.");
            }
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved succesfully");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                bool isComplete = bool.Parse(data[3]);
                SimpleGoal sg = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                if (isComplete) sg.RecordEvent(); _goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "CheckListGoal")
            {
                int amountCompleted = int.Parse(data[3]);
                int target = int.Parse(data[4]);
                int bonus = int.Parse(data[5]);
                CheckListGoal cg = new CheckListGoal(data[0], data[1], int.Parse(data[2]), target, bonus);

                for (int j = 0; j < amountCompleted; j++)
                {
                    cg.RecordEvent();
                }
                _goals.Add(cg);
            }
        }
        Console.WriteLine("Goals loaded succesfully!");
    }
    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine($"\nYou Have {_score} points.");
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbay!");
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again");
            }
        }
    }
}