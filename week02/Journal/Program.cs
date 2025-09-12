using System;
//I have added a title to the journal entries, you are now prompted to enter a title which is then saved along the other information when loaded
class Program
{
    static void Main(string[] args)
    {
        int exitMenu;

        Console.WriteLine("Welcome to the Journal Program.");
        
        Journal myEntry = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            exitMenu = int.Parse(Console.ReadLine());

            if (exitMenu == 1)
            {
                myEntry.AddEntry();
            }
            else if (exitMenu == 2)
            {
                myEntry.DisplayAll();
            }
            else if (exitMenu == 3)
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                myEntry.LoadFromFile(filename);
            }
            else if (exitMenu == 4)
            {
                Console.WriteLine("What is the filename? ");
                string fileName = Console.ReadLine();
                myEntry.SaveToFile(fileName);
            }
            else
            {
                Console.WriteLine("Thank you, good-bye.");
            }

        } while (exitMenu != 5);
    }
}