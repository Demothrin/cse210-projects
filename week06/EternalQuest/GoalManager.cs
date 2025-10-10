using System.ComponentModel;
using System.Reflection.Metadata;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;
    private int _nextLevel = 100;

    public GoalManager()
    {

    }

    public void Start()
    {
        int mQuit;
        do
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            mQuit = int.Parse(Console.ReadLine());

            if (mQuit == 1)
            {
                Console.Clear();
                CreateGoal();
            }

            else if (mQuit == 2)
            {
                Console.Clear();
                ListGoalDetails();
                Console.ReadLine();
            }
            else if (mQuit == 3)
            {
                Console.Clear();
                SaveGoals();
            }
            else if (mQuit == 4)
            {
                Console.Clear();
                LoadGoals();
            }
            else if (mQuit == 5)
            {
                Console.Clear();
                RecordEvent();
                Console.ReadLine();
            }
            

        } while (mQuit != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.Clear();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Current Level: {_level}");
        Console.WriteLine($"Next level in {_nextLevel - _score} points.");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int number = 1;
        foreach (Goal g in _goals)
        {

            Console.WriteLine($"{number}. {g.CompletionStatus()} {g.GetName()}");
            number++;
        }

    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int number = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{number}. {g.GetDetailsString()}");
            number++;
        }
    }
    public void CreateGoal()
    {
        string name;
        string desc;
        string points;
        int amount;
        int bonus;

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int gSelect = int.Parse(Console.ReadLine());

        if (gSelect == 1)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            desc = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            points = Console.ReadLine();

            SimpleGoal goal = new SimpleGoal(name, desc, points);
            _goals.Add(goal);
        }
        else if (gSelect == 2)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            desc = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            points = Console.ReadLine();

            EternalGoal goal = new EternalGoal(name, desc, points);
            _goals.Add(goal);
        }
        else if (gSelect == 3)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            desc = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            points = Console.ReadLine();
            Console.WriteLine("How many times does this goal need to be completed for a bonus? ");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for completing it that many times? ");
            bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, desc, points, amount, bonus);
            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("That is not a valid choice. Returning to menu.");
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Select a choice from the menu:");

        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();



            if (selectedGoal is ChecklistGoal checklist && checklist.IsCompleted())
            {
                _score += checklist.GetBonus();
            }

            Console.WriteLine($"You have earned {selectedGoal.GetPoints()} points.");
            Console.WriteLine($"Your total score is now {_score}.");
        }
        else
        {
            Console.WriteLine("That is not a valid choice. Returning to menu.");
        }
        CheckLevel();
        
    }
    public void SaveGoals()
    {
        Console.Write("Enter a file name to save your goals into. (e.g goals.txt) -- ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_level);
            writer.WriteLine(_nextLevel);

            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetType().Name + ":" + g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals Saved.");
        Console.ReadLine();
    }
    public void LoadGoals()
    {
        Console.Write("Enter the file name you would like to load your goals from. (e.g goals.txt) -- ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File could not be found.");
            Console.ReadLine();
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        _goals.Clear();
        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);
        _nextLevel = int.Parse(lines[2]);

        for (int i = 3; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string[] data = parts[1].Split(",");

            if (goalType == "SimpleGoal")
            {
                string name = data[0];
                string desc = data[1];
                string points = data[2];
                bool complete = bool.Parse(data[3]);

                SimpleGoal goal = new SimpleGoal(name, desc, points);
                if (complete)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = data[0];
                string desc = data[1];
                string points = data[2];

                EternalGoal goal = new EternalGoal(name, desc, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = data[0];
                string desc = data[1];
                string points = data[2];
                int target = int.Parse(data[3]);
                int bonus = int.Parse(data[4]);
                int amountCompleted = int.Parse(data[5]);


                ChecklistGoal goal = new ChecklistGoal(name, desc, points, target, bonus);
                goal.SetProgress(amountCompleted);
                _goals.Add(goal);

            }



        }

        Console.WriteLine("Goals loaded.");
        Console.ReadLine();
    }
    private void CheckLevel()
    {
        while (_score >= _nextLevel)
        {
            _level++;
            Console.WriteLine($"You just leveled up! You are now level {_level}.");

            _nextLevel += 100;
        }
    }

}