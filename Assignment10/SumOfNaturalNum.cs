using System;

class SumOfNaturalNum
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int sumRecursive = SumUsingRecursion(n);
            int sumFormula = SumUsingFormula(n);

            Console.WriteLine("Sum using recursion: " + sumRecursive);
            Console.WriteLine("Sum using formula: " + sumFormula);

            if (sumRecursive == sumFormula)
            {
                Console.WriteLine("Both results are correct and equal.");
            }
            else
            {
                Console.WriteLine("The results do not match.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid natural number.");
        }
    }

    public static int SumUsingRecursion(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n + SumUsingRecursion(n - 1);
    }

    public static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
