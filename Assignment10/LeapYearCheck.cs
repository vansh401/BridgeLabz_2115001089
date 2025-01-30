using System;

class LeapYearCheck
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (year >= 1582)
        {
            if (IsLeapYear(year))
            {
                Console.WriteLine("The year " + year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine("The year " + year + " is not a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine("Year must be greater than or equal to 1582.");
        }
    }

    public static bool IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        return false;
    }
}
