using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int numList;
        float sum = 0;
        float average;
        int largest = -99999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string stringList = Console.ReadLine();
            numList = int.Parse(stringList);
            if (numList != 0)
            {
                numbers.Add(numList);
            }

        } while (numList != 0);

        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
        }

        average = sum / numbers.Count;

        Console.WriteLine($"The sum of the numbers is {sum}");
        Console.WriteLine($"The average of the numbers is {average}");
        Console.WriteLine($"The largest number is {largest}");
    }
}