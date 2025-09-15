using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Fraction b = new Fraction(6);
        Fraction c = new Fraction(6, 7);


        Console.WriteLine($"{a.GetFractionString()}, {b.GetFractionString()}, {c.GetFractionString()}");
        Console.WriteLine($"{a.GetDecimalValue()}, {b.GetDecimalValue()}, {c.GetDecimalValue()}");
    }
}