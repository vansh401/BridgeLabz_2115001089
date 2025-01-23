using System;

class YoungestAndTallestFriend
{
    static void Main()
    {
        Console.Write("Enter Amar's age: ");
        int amarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's age: ");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's age: ");
        int anthonyAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Amar's height (in cm): ");
        int amarHeight = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's height (in cm): ");
        int akbarHeight = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's height (in cm): ");
        int anthonyHeight = int.Parse(Console.ReadLine());

        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        string youngestFriend = "";

        if (youngestAge == amarAge)
        {
            youngestFriend = "Amar";
        }
        else if (youngestAge == akbarAge)
        {
            youngestFriend = "Akbar";
        }
        else
        {
            youngestFriend = "Anthony";
        }

        int tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
        string tallestFriend = "";

        if (tallestHeight == amarHeight)
        {
            tallestFriend = "Amar";
        }
        else if (tallestHeight == akbarHeight)
        {
            tallestFriend = "Akbar";
        }
        else
        {
            tallestFriend = "Anthony";
        }

        Console.WriteLine(youngestFriend + " is the youngest friend with an age of " + youngestAge + " years.");
        Console.WriteLine(tallestFriend + " is the tallest friend with a height of " + tallestHeight + " cm.");
    }
}
