using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _titleEntry;

    public Entry()
    {

    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Title: {_titleEntry}");
        Console.WriteLine("");
        Console.WriteLine($"Date: {_date} Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("");
    }
}