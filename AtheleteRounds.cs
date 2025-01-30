using System;

class AtheleteRounds
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the first side of the park in meters: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second side of the park in meters: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the third side of the park in meters: ");
        double side3 = double.Parse(Console.ReadLine());

        double perimeter = CalculatePerimeter(side1, side2, side3);

        double rounds = CalculateRounds(perimeter, 5000); 

        Console.WriteLine("The athlete must complete " + Math.Ceiling(rounds) + " rounds to complete a 5 km run.");
    }

    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    static double CalculateRounds(double perimeter, double distance)
    {
        return distance / perimeter;
    }
}
