using System;

class KilometersToMiles
{
    static void Main(string[] args)
    {
        Console.Write("Enter distance in kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());

        double miles = kilometers * 0.621371;

        Console.WriteLine("Distance in miles is: " + miles);
    }
}
