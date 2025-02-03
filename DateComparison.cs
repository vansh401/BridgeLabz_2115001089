using System;

class DateComparison
{
    static void Main()
    {
        Console.WriteLine("Enter first date (dd mm yyyy):");
        int day1 = int.Parse(Console.ReadLine());
        int month1 = int.Parse(Console.ReadLine());
        int year1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second date (dd mm yyyy):");
        int day2 = int.Parse(Console.ReadLine());
        int month2 = int.Parse(Console.ReadLine());
        int year2 = int.Parse(Console.ReadLine());

        DateTime date1 = new DateTime(year1, month1, day1);
        DateTime date2 = new DateTime(year2, month2, day2);

        if (date1 < date2)
            Console.WriteLine("The first date is before the second date.");
        else if (date1 > date2)
            Console.WriteLine("The first date is after the second date.");
        else
            Console.WriteLine("Both dates are the same.");
    }
}
