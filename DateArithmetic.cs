using System;

class DateArithmetic
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(year, month, day);
        date = date.AddDays(7).AddMonths(1).AddYears(2).AddDays(-21);

        Console.WriteLine("Updated Date: " + date.ToString("yyyy-MM-dd"));
    }
}
