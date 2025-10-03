using System;
// moved the GetRandomPrompt from the suggested design to the base activity class and included code in listing activity 
// to prevent blank responses from being added to the list for additional creativity
class Program
{
    static void Main(string[] args)
    {
        int mQuit;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            mQuit = int.Parse(Console.ReadLine());


            if (mQuit == 1)
            {
                Console.Clear();
                BreathingActivity bRun = new BreathingActivity("Breathing", "This activity will help you to relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.");

                bRun.Run();
            }
            else if (mQuit == 2)
            {
                Console.Clear();
                ReflectingActivity rRun = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                rRun.Run();
            }
            else if (mQuit == 3)
            {
                Console.Clear();
                ListingActivity lRun = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                lRun.Run();
            }
            else if (mQuit == 4)
            {
                Console.Clear();
                Console.WriteLine("I hope you are feeling more relaxed. Good Bye.");

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number. (1-4)");
                Console.WriteLine();
            }
        } while (mQuit != 4);    
    }
}