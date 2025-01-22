using System;

class AreaOfCircle
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("Area of circle is: " + area);
    }
}
