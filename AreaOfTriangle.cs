using System;

class AreaOfTriangle
{
    static void Main()
    {
        Console.Write("Enter the base(cm) : ");
        double baseCm = double.Parse(Console.ReadLine());

        Console.Write("Enter the height(cm) : ");
        double heightCm = double.Parse(Console.ReadLine());

        double areaCm = 0.5 * baseCm * heightCm;
        double areaIn = areaCm / 6.4516;

        Console.WriteLine("The area of the triangle is " + areaCm + " square centimeters and " + areaIn + " square inches.");
    }
}
