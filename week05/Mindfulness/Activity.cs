public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected Random _random = new Random();

    public Activity(string name, string desc)
    {
        _name = name;
        _description = desc;

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine("How long in seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());


    }
    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity.");
        Console.WriteLine("Returning you to the menu...");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();

    }
    protected string GetRandomPrompt(List<string> list)
    {
        int i = _random.Next(list.Count);
        return list[i];
    }
}