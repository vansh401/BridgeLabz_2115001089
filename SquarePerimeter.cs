using System;

class SquarePerimeter
{
    static void Main()
    {
        Console.Write("Enter the perimeter : ");
        double perimeter = double.Parse(Console.ReadLine());

        double side = perimeter / 4;

        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}
