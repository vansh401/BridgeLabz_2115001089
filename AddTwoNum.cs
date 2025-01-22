using System;

class AddTwoNum
{
    static void Main(string[] args)
    {
        Console.Write("Enter Num1: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter Num2: ");
        double num2 = double.Parse(Console.ReadLine());

        double sum = num1 + num2;

        Console.WriteLine("Sum: " + sum);
    }
}
