using System.IO;
using System.Reflection;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void AddEntry()
    {
        Console.WriteLine("");
        string randomPrompt = new PromptGenerator().GetRandomPrompt();
        Console.WriteLine($"{randomPrompt}");
        Console.Write("What would you like to title this entry? ");
        string entryTitle = Console.ReadLine();
        Console.Write("Entry: ");

        Entry newEntry = new Entry
        {
            _titleEntry = entryTitle,
            _date = DateTime.Now.ToShortDateString(),
            _promptText = randomPrompt,
            _entryText = Console.ReadLine()

        };

        _entries.Add(newEntry);
        Console.WriteLine("");
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._titleEntry}|{e._date}|{e._promptText}|{e._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] part = line.Split("|");

            string title = part[0];
            string date = part[1];
            string prompt = part[2];
            string entry = part[3];

            Entry newEntry = new Entry
            {
                _titleEntry = title,
                _date = date,
                _promptText = prompt,
                _entryText = entry
            };

            _entries.Add(newEntry);
        }
    }
}