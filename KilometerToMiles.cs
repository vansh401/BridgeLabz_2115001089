using System;

class KilometerToMiles
{
    static void Main()
    {
        Console.Write("Enter distance in kilometers: ");
        double km = double.Parse(Console.ReadLine());

        double miles = km / 1.6;

        Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
    }
}
