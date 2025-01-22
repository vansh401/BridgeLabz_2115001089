using System;

class AverageCalculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter Num1: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter Num2: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter Num3: ");
        double num3 = double.Parse(Console.ReadLine());

        double average = (num1 + num2 + num3) / 3;

        Console.WriteLine("The average is: " + average);
    }
}
