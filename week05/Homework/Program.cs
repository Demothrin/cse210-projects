using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Samuel Bennett", "Multiplication");
        string asum = assign1.GetSummary();
        Console.WriteLine(asum);

        Console.WriteLine();

        MathAssignment student1 = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8-19");
        string sum1 = student1.GetSummary();
        string list1 = student1.GetHomeworkList();
        Console.WriteLine($"{sum1}\n{list1}");

        Console.WriteLine();

        WritingAssignment student2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string sum2 = student2.GetSummary();
        string list2 = student2.GetWritingInformation();
        Console.WriteLine($"{sum2}\n{list2}");
    }
}