using System;

class NaturalNumberSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            int formulaSum = n * (n + 1) / 2;
            int loopSum = 0;
            int i = 1;
            while (i <= n)
            {
                loopSum += i;
                i++;
            }

            Console.WriteLine("Sum using formula: " + formulaSum);
            Console.WriteLine("Sum using while loop: " + loopSum);

            if (formulaSum == loopSum)
                Console.WriteLine("Both calculations are correct!");
            else
                Console.WriteLine("There is a difference in the computations.");
        }
        else
        {
            Console.WriteLine("The input is not a natural number.");
        }
    }
}
