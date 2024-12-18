public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        string option = "";

        while (option != "6")
        {
            DisplayPlayerInfo();

            Console.Write(
                """
                Menu Options: 
                    1. Create New Goal
                    2. List Goals
                    3. Save Goals
                    4. Load Goals
                    5. Record Event
                    6. Quit

                Select a choice from the menu: 
                """
            );
            option = Console.ReadLine();
            
            switch (option)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
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
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are: ");
        
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"    {i + 1}. {goal.GetDetailsString()}");
        }

        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.Write(
            """
            The types of Goals are:
                1. Simple Goal
                2. Eternal Goal
                3. Checklist Goal
            Which type of goal would you like to create? 
            """
        );
        string option = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        int points = RequestInteger("What is the amount of points associated with this goal? ");
        
        if (option == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (option == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (option == "3")
        {
            int target = RequestInteger("How many times does this goal need to be accomplished for a bonus? ");
            int bonus = RequestInteger("What is the bonus for accomplishing it that many times? ");

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetDetailsString()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int.TryParse(Console.ReadLine(), out int option);

        int reward = _goals[option - 1].RecordEvent();
        _score += reward;

        Console.WriteLine($"Congratulations! You have earned {reward} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        List<string> lines = new List<string>();
        lines.Add($"{_score}");

        foreach (Goal goal in _goals)
        {
            lines.Add(goal.GetStringRepresentation());
        }

        File.WriteAllLines(filename, lines);
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];

            if (i == 0)
            {
                int.TryParse(line, out _score);
                continue;
            }

            string[] goalParts = line.Split(":");
            string goalType = goalParts[0];
            string goalDetails = goalParts[1];

            if (goalType == typeof(SimpleGoal).Name)
            {
                _goals.Add(new SimpleGoal(goalDetails));
            }
            else if (goalType == typeof(EternalGoal).Name)
            {
                _goals.Add(new EternalGoal(goalDetails));
            }
            else if (goalType == typeof(ChecklistGoal).Name)
            {
                _goals.Add(new ChecklistGoal(goalDetails));
            }
        }
    }

    private int RequestInteger(string prompt)
    {
        int input = 0;
        bool isValidInput = false;
        while (!isValidInput)
        {
            Console.Write(prompt);
            isValidInput = int.TryParse(Console.ReadLine(), out input);
        }

        return input;
    }
}