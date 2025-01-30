using System;

class NaturalNumberSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());

        int sum = CalculateSum(n);

        Console.WriteLine("The sum of the first " + n + " natural numbers is: " + sum);
    }

    static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}
