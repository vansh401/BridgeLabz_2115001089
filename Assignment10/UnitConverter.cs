using System;

public class Units
{
    public static double KilometersToMiles(double kilometers)
    {
        double conversionFactor = 0.621371;
        return kilometers * conversionFactor;
    }

    public static double MilesToKilometers(double miles)
    {
        double conversionFactor = 1.60934;
        return miles * conversionFactor;
    }

    public static double MetersToFeet(double meters)
    {
        double conversionFactor = 3.28084;
        return meters * conversionFactor;
    }

    public static double FeetToMeters(double feet)
    {
        double conversionFactor = 0.3048;
        return feet * conversionFactor;
    }
}

class UnitConverter
{
    static void Main(string[] args)
    {
        Console.Write("Enter distance in kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());
        Console.WriteLine(kilometers + " kilometers is equal to " + Units.KilometersToMiles(kilometers) + " miles.");

        Console.Write("Enter distance in miles: ");
        double miles = double.Parse(Console.ReadLine());
        Console.WriteLine(miles + " miles is equal to " + Units.MilesToKilometers(miles) + " kilometers.");

        Console.Write("Enter distance in meters: ");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(meters + " meters is equal to " + Units.MetersToFeet(meters) + " feet.");

        Console.Write("Enter distance in feet: ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet is equal to " + Units.FeetToMeters(feet) + " meters.");
    }
}
