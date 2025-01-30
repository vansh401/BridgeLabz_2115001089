using System;

class EuclideanDistance
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates of point A (x1, y1):");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinates of point B (x2, y2):");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean distance between the points: " + distance);

        double[] lineEquation = FindLineEquation(x1, y1, x2, y2);
        Console.WriteLine("Equation of the line: y = " + lineEquation[0] + "x + " + lineEquation[1]);
    }

    static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double slope = (y2 - y1) / (x2 - x1);
        double yIntercept = y1 - slope * x1;
        return new double[] { slope, yIntercept };
    }
}
