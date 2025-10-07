using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square newShape = new Square("red", 5);
        shapes.Add(newShape);

        Rectangle newRec = new Rectangle("Blue", 3, 4);
        shapes.Add(newRec);

        Circle newCir = new Circle("Green", 13);
        shapes.Add(newCir);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The color of the shape is {color} and the area is {area}");
        }
      
    }
}