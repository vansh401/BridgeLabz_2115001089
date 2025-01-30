using System;

class TrignometricFunction
{
    static void Main(string[] args)
    {
        Console.Write("Enter the angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        double[] trigFunctions = CalculateTrigonometricFunctions(angle);

        Console.WriteLine("Sine of the angle: " + trigFunctions[0]);
        Console.WriteLine("Cosine of the angle: " + trigFunctions[1]);
        Console.WriteLine("Tangent of the angle: " + trigFunctions[2]);
    }

    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = Math.PI * angle / 180;

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }
}
