using System;

public class Units
{
    public static double ConvertYardsToFeet(double yards)
    {
        double yardsToFeet = 3;
        return yards * yardsToFeet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        double feetToYards = 0.333333;
        return feet * feetToYards;
    }

    public static double ConvertMetersToInches(double meters)
    {
        double metersToInches = 39.3701;
        return meters * metersToInches;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        double inchesToMeters = 0.0254;
        return inches * inchesToMeters;
    }

    public static double ConvertInchesToCentimeters(double inches)
    {
        double inchesToCm = 2.54;
        return inches * inchesToCm;
    }
}

class UnitConverterYardsToFeet
{
    static void Main(string[] args)
    {
        Console.Write("Enter value in yards: ");
        double yards = double.Parse(Console.ReadLine());
        Console.WriteLine(yards + " yards is " + Units.ConvertYardsToFeet(yards) + " feet.");

        Console.Write("Enter value in feet: ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet + " feet is " + Units.ConvertFeetToYards(feet) + " yards.");

        Console.Write("Enter value in meters: ");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine(meters + " meters is " + Units.ConvertMetersToInches(meters) + " inches.");

        Console.Write("Enter value in inches: ");
        double inches = double.Parse(Console.ReadLine());
        Console.WriteLine(inches + " inches is " + Units.ConvertInchesToMeters(inches) + " meters.");
        Console.WriteLine(inches + " inches is " + Units.ConvertInchesToCentimeters(inches) + " centimeters.");
    }
}
