using System;

class FactorCalculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("Factors of " + number + " are:");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }

        int sum = CalculateSum(factors);
        Console.WriteLine("\nSum of the factors: " + sum);

        int sumOfSquares = CalculateSumOfSquares(factors);
        Console.WriteLine("Sum of squares of the factors: " + sumOfSquares);

        int product = CalculateProduct(factors);
        Console.WriteLine("Product of the factors: " + product);
    }

    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    public static int CalculateSum(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }
        return sum;
    }

    public static int CalculateSumOfSquares(int[] factors)
    {
        int sumOfSquares = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sumOfSquares += (int)Math.Pow(factors[i], 2);
        }
        return sumOfSquares;
    }

    public static int CalculateProduct(int[] factors)
    {
        int product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }
        return product;
    }
}
