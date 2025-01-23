using System;

class RocketLaunchCounterForLoop
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number for the countdown: ");
        int counter = int.Parse(Console.ReadLine());

        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
