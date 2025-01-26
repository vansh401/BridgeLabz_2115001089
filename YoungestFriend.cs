using System;

class YoungestFriend
{
    static void Main()
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age for " + friends[i] + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height for " + friends[i] + " (in cm): ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        int youngestAge = ages[0];
        string youngestFriend = friends[0];
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < youngestAge)
            {
                youngestAge = ages[i];
                youngestFriend = friends[i];
            }
        }

        double tallestHeight = heights[0];
        string tallestFriend = friends[0];
        for (int i = 1; i < 3; i++)
        {
            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                tallestFriend = friends[i];
            }
        }

        Console.WriteLine("The youngest friend is " + youngestFriend + " with age " + youngestAge + ".");
        Console.WriteLine("The tallest friend is " + tallestFriend + " with height " + tallestHeight + " cm.");
    }
}
