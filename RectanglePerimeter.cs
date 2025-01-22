using System;

class RectanglePerimeter
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter the breadth: ");
        double breadth = double.Parse(Console.ReadLine());

        double perimeter = 2 * (length + breadth);

        Console.WriteLine("Perimeter of rectangle is: " + perimeter);
    }
}
