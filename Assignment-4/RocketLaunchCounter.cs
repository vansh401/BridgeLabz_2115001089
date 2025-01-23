using System;

class RocketLaunchCounter
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number for the countdown: ");
        int counter = int.Parse(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
