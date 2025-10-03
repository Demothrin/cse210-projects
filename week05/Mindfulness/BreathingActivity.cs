public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string desc) : base(name, desc)
    {
        _name = name;
        _description = desc;
       
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready...");
        ShowSpinner(8);
        Console.Clear();

        int rotation = 10;
        int rotations = _duration / rotation;

        for (int i = 0; i < rotations; i++)
        {
            Console.Write("Breath in ...");
            ShowCountDown(5);

            Console.Write("Breath out ...");
            ShowCountDown(5);
        }

        DisplayEndingMessage();     
        Console.Clear();  

    }
}