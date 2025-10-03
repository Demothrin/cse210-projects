public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?",
    "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?" };

    public ListingActivity(string name, string desc) : base(name, desc)
    {
        _name = name;
        _description = desc;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        GetRandomPrompt(_prompts);
        Console.WriteLine("Get ready to start listing...");
        ShowSpinner(4);
        Console.Clear();

        Console.WriteLine("Go!");
        List<string> results = GetListFromUser();

        Console.WriteLine("Your responses where:");

        foreach (string s in results)
        {
            Console.WriteLine($" -{s}");
        }
        Console.Write("Press enter to end this acitivity.");
        Console.ReadLine();

        DisplayEndingMessage();
        Console.Clear();
        


    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string listItem = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(listItem))
            {
                userList.Add(listItem);
                _count++;
            }
            Console.Clear();
        }

        Console.Clear();
        Console.WriteLine($"All done! You listed {_count} items!");
        ShowSpinner(4);
        Console.Clear();
        return userList;
    }
}