using System.IO.Compression;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string> {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    

    public ReflectingActivity(string name, string desc) : base(name, desc)
    {
        _name = name;
        _description = desc;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        DisplayPrompt();
        Console.Clear();
        DisplayQuestions();
        DisplayEndingMessage();
        Console.Clear();

    }
    
    public string GetRandonQuestion()
    {
        int i = _random.Next(_questions.Count);
        return _questions[i];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt(_prompts)} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to your experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);

        int rotation = 10;
        int rotations = _duration / rotation;

        Console.Clear();

        for (int i = 0; i < rotations; i++)
        {
            Console.WriteLine($"{GetRandonQuestion()}");
            ShowSpinner(10);
            Console.Clear();
        }

    }
}