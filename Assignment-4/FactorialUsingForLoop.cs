using System;

class FactorialUsingForLoop
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("The factorial of " + number + " is " + factorial);
        }
        else
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
    }
}
