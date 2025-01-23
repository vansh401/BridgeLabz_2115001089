using System;

class Factorial
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0)
        {
            int factorial = 1;
            int i = number;

            while (i > 1)
            {
                factorial *= i;
                i--;
            }
            Console.WriteLine("The factorial of " + number + " is " + factorial);
        }
        else
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
    }
}
