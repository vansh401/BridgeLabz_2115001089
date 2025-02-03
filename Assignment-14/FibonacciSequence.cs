using System;

class FibonacciSequence
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of terms:");
        int terms = int.Parse(Console.ReadLine());

        getFibonacci(terms);
    }

    public static void getFibonacci(int n)
    {
        int first = 0, second = 1, third;

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");
            third = first + second;
            first = second;
            second = third;
        }
    }
}
