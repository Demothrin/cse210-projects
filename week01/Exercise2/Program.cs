using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the exam score? ");
        string valueInText = Console.ReadLine();

        int letterGrade = int.Parse(valueInText);

        string plusMinus = "";
        string result;

        if (letterGrade >= 90)
        {
            result = "A";
        }
        else if (letterGrade >= 80)
        {
            result = "B";
        }
        else if (letterGrade >= 70)
        {
            result = "C";
        }
        else if (letterGrade >= 60)
        {
            result = "D";
        }
        else
        {
            result = "F";
        }

        if (!(result == "A" || result == "F"))
        {
            float remainderNumber = letterGrade % 10;

            if (remainderNumber >= 7)
            {
                plusMinus = "+";
            }
            else if (remainderNumber <= 3)
            {
                plusMinus = "-";
            }
            else
            {
                plusMinus = "";
            }
        }


        Console.WriteLine($"Your grade is {result}{plusMinus}");

        if (letterGrade >= 70)
        {
            Console.WriteLine("Congratulations for passing!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }

    }
}