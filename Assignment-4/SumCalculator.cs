using System;

class SumCalculator
{
    static void Main(string[] args)
    {
        double total = 0.0;

        Console.WriteLine("Enter numbers to add to the total (enter 0 or a negative number to stop):");

        while (true)
        {
            double userInput = double.Parse(Console.ReadLine());

            if (userInput <= 0)
                break;

            total += userInput;
        }

        Console.WriteLine("The total value is: " + total);
    }
}
