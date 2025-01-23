using System;

class NaturalNumberCheck
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
            Console.WriteLine("The sum of " + number + " natural numbers is " + (number * (number + 1) / 2));
        else
            Console.WriteLine("The number " + number + " is not a natural number.");
    }
}
