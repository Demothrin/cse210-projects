using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {

        int guessNumber;
        int magicNumber;

        Random randomGenerator = new Random();

        magicNumber = randomGenerator.Next(1, 101);

        do
        {

            Console.Write("Guess the magic number: ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        } while (!(guessNumber == magicNumber));
    }
}