using System;

class EarthVolume
{
    static void Main()
    {
        double radius = 6378;

        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        double volumeMiles = volume * 0.239913;

        Console.WriteLine("The volume of Earth in cubic kilometers is " + volume + " and cubic miles is " + volumeMiles);
    }
}
