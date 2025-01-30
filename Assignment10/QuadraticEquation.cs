using System;

public class QuadraticEquation
{
    public static double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else
        {
            return new double[] { }; 
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 2)
        {
            Console.WriteLine("The roots are: " + roots[0] + " and " + roots[1]);
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("There is only one root: " + roots[0]);
        }
        else
        {
            Console.WriteLine("There are no real roots.");
        }
    }
}
