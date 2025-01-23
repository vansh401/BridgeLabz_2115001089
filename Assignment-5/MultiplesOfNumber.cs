using System;

class MultiplesOfNumber
{
    static void Main()
    {
        Console.Write("Enter a number(below 100): ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Multiples of " + number + " are :");

        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
