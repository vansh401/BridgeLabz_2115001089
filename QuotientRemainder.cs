using System;

class QuotientRemainder
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number (dividend): ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number (divisor): ");
        int divisor = int.Parse(Console.ReadLine());

        if (divisor == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return;
        }

        int[] result = FindRemainderAndQuotient(number, divisor);

        Console.WriteLine("The quotient is: " + result[0]);
        Console.WriteLine("The remainder is: " + result[1]);
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }
}
