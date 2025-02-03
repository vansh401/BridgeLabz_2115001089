using System;

class DateFormatting
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("Format 1: " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Format 2: " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Format 3: " + currentDate.ToString("ddd, MMM dd, yyyy"));
    }
}
