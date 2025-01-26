using System;

class MeanHeightCalculator
{
    static void Main()
    {
        double[] heights = new double[11]; 
        double sum = 0; 

        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter the height of player " + (i + 1) + " (in cm): ");
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i]; 
        }
        double mean = sum / heights.Length;

        
        Console.WriteLine("The mean height of the football team is: " + mean + " cm");
    }
}
