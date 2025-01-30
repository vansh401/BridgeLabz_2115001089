using System;

class SpringSeason 
{
    static void Main(string[] args)
    {
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the day (1-31): ");
        int day = int.Parse(Console.ReadLine());

        bool isSpring = CheckSpringSeason(month, day);

        if (isSpring)
            Console.WriteLine("It's a Spring Season.");
        else
            Console.WriteLine("Not a Spring Season.");
    }

    static bool CheckSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20))
        {
            return true;
        }
        return false;
    }
}
