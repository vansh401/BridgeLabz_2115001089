using System;

public class FootballTeam
{
    public static int[] GenerateRandomHeights(int size)
    {
        Random random = new Random();
        int[] heights = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(150, 251);
        }
        
        return heights;
    }

    public static int FindSum(int[] heights)
    {
        int sum = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }
        return sum;
    }

    public static double FindMean(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    public static int FindShortest(int[] heights)
    {
        int shortest = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] < shortest)
            {
                shortest = heights[i];
            }
        }
        return shortest;
    }

    public static int FindTallest(int[] heights)
    {
        int tallest = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallest)
            {
                tallest = heights[i];
            }
        }
        return tallest;
    }

    public static void Main(string[] args)
    {
        int[] heights = GenerateRandomHeights(11);

        Console.WriteLine("Heights of the players:");
        foreach (int height in heights)
        {
            Console.WriteLine(height + " cm");
        }

        int sum = FindSum(heights);
        double mean = FindMean(heights);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine("Results:");
        Console.WriteLine("Sum of heights: " + sum + " cm");
        Console.WriteLine("Mean height: " + mean + " cm");
        Console.WriteLine("Shortest height: " + shortest + " cm");
        Console.WriteLine("Tallest height: " + tallest + " cm");
    }
}
