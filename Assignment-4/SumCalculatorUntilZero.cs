using System;

class SumCalculatorUntilZero
{
    static void Main(string[] args)
    {
        double total = 0.0;
        double userInput;

        Console.WriteLine("Enter numbers to add to the total (enter 0 to stop):");

        do
        {
            userInput = double.Parse(Console.ReadLine());
            total += userInput;
        } while (userInput != 0);

        Console.WriteLine("The total value is: " + total);
    }
}
