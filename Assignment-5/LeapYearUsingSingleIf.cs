using System;

class LeapYearUsingSingleIf
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year (>= 1582): ");
        int year = int.Parse(Console.ReadLine());

        if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0))
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}
