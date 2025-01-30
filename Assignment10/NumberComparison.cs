using System;

public class NumberComparison
{
    public static string IsPositiveOrNegative(int number)
    {
        if (number > 0)
            return "positive";
        else if (number < 0)
            return "negative";
        else
            return "zero";
    }

    public static string IsEvenOrOdd(int number)
    {
        if (number % 2 == 0)
            return "even";
        else
            return "odd";
    }

    public static int CompareNumbers(int number1, int number2)
    {
        if (number1 > number2)
            return 1;
        else if (number1 < number2)
            return -1;
        else
            return 0;
    }

    public static void Main(string[] args)
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            string result = IsPositiveOrNegative(numbers[i]);
            if (result == "positive")
            {
                string evenOdd = IsEvenOrOdd(numbers[i]);
                Console.WriteLine(numbers[i] + " is positive and " + evenOdd + ".");
            }
            else if (result == "negative")
            {
                Console.WriteLine(numbers[i] + " is negative.");
            }
            else
            {
                Console.WriteLine(numbers[i] + " is zero.");
            }
        }

        int comparisonResult = CompareNumbers(numbers[0], numbers[numbers.Length - 1]);
        if (comparisonResult == 1)
        {
            Console.WriteLine("The first number is greater than the last number.");
        }
        else if (comparisonResult == -1)
        {
            Console.WriteLine("The first number is less than the last number.");
        }
        else
        {
            Console.WriteLine("The first number is equal to the last number.");
        }
    }
}
