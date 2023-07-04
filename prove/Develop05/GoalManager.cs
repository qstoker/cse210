public class GoalManager
{
    List<Goal> _goals;
    int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string menuChoice = "";

        while (menuChoice != "6")
        {
            Console.Clear();
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Please enter a valid input.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string newGoalChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("How many points are associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (newGoalChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points, false));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does it need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, 0, target, bonus));
                break;
        }
    }

    public void ListGoalDetails()
    {
        int goalCount = 0;

        Console.Clear();
        Console.WriteLine("The goals are:");

        foreach (Goal goal in _goals)
        {
            goalCount++;
            Console.WriteLine($"{goalCount}. {goal.GetDetailsString()}");
        }

        Console.Write("Press 'ENTER' to return to the menu.");
        Console.ReadLine();
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            string[] mainParts = line.Split(":");

            string goalType = mainParts[0];
            string goalDetails = mainParts[1];

            string[] detailParts = goalDetails.Split(",");

            string name = detailParts[0];
            string description = detailParts[1];
            int points = int.Parse(detailParts[2]);

            switch (goalType)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(detailParts[3]);

                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "ChecklistGoal":
                    int amountCompleted = int.Parse(detailParts[3]);
                    int target = int.Parse(detailParts[4]);
                    int bonus = int.Parse(detailParts[5]);

                    _goals.Add(
                        new ChecklistGoal(name, description, points, amountCompleted, target, bonus)
                    );
                    break;
            }
        }
    }

    public void RecordEvent()
    {
        int goalCount = 0;

        Console.Clear();
        Console.WriteLine("The goals are:");

        foreach (Goal goal in _goals)
        {
            goalCount++;
            Console.WriteLine($"{goalCount}. {goal.GetName()}");
            // Console.WriteLine($"{goalCount}. {nameof(goal)}");
        }

        Console.Write("Which goal did you accomplish? ");
        int recordGoalChoice = int.Parse(Console.ReadLine());

        int newPoints = _goals[recordGoalChoice - 1].RecordEvent();
        _score += newPoints;

        if (newPoints == 0)
        {
            Console.WriteLine("You've already completed that goal.");
            Console.WriteLine($"You have {_score} points.");
            ShowSpinner(5);
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {newPoints} points");
            Console.WriteLine($"You now have {_score} points.");
            ShowSpinner(5);
        }
    }

    // public void ListGoalNames() { }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}
