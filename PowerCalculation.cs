using System;

class PowerCalculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter base: ");
        double baseNum = double.Parse(Console.ReadLine());

        Console.Write("Enter exponent: ");
        double exponent = double.Parse(Console.ReadLine());

        double ans = Math.Pow(baseNum, exponent);

        Console.WriteLine("Answer: " + ans);
    }
}
