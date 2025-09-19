using System;
// I have added the option to choose how many letter you want hidden each time variable for multiple verses is created so you can store information before loading it into the constructor.
class Program
{
    static void Main(string[] args)
    {
        string book = "Ether";
        int chapter = 12;
        int verse = 27;
        int endVerse;
        string textScripture = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        string leaveProgram;

        Console.WriteLine("Welcome to the Scripture Memorizer Program");
        Console.Write("How many words to you want to remove each time? (1-3) ");
        int removeWords = int.Parse(Console.ReadLine());
        
        Reference memReference = new Reference(book, chapter, verse);
        Scripture memScripture = new Scripture(memReference, textScripture);

        do
        {
            Console.Clear();
            Console.WriteLine(memReference.GetDisplayText());
            Console.WriteLine(memScripture.GetDisplayText());

            if (memScripture.IsCompletelyHidden()) break;

            Console.WriteLine("\nPress 'Enter' to continue or type 'quit' to exit.");
            leaveProgram = Console.ReadLine();

            if (leaveProgram != "quit")
            {
                memScripture.HideRandomWords(removeWords);
            }





        } while (leaveProgram != "quit");

    }
}