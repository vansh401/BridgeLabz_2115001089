using System;

class FactorialByRecursion
{
    public static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        int result = getFactorial(num);
        Console.WriteLine("Factorial of " + num + " is: " + result);
    }

    public static int getFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * getFactorial(n - 1);
    }
}
