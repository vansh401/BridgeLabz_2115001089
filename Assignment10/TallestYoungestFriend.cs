using System;

public class TallestYoungestFriend
{
    public static int YoungestFriend(int[] ages)
    {
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }
        return youngestIndex;
    }

    public static int TallestFriend(double[] heights)
    {
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }
        return tallestIndex;
    }

    public static void Main(string[] args)
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < names.Length; i++)
        {
            Console.Write("Enter the age of " + names[i] + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of " + names[i] + " (in meters): ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        int youngestIndex = YoungestFriend(ages);
        int tallestIndex = TallestFriend(heights);

        Console.WriteLine(names[youngestIndex] + " is the youngest with an age of " + ages[youngestIndex] + ".");
        Console.WriteLine(names[tallestIndex] + " is the tallest with a height of " + heights[tallestIndex] + " meters.");
    }
}
