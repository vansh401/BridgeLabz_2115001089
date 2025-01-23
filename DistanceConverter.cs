using System;

class DistanceConverter
{
    static void Main()
    {
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = double.Parse(Console.ReadLine());

        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;

        Console.WriteLine("The distance in feet is " + distanceInFeet + ", in yards is " + distanceInYards + ", and in miles is " + distanceInMiles);
    }
}
