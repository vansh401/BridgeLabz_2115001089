using System;

public class RandomValueCalculator
{
    public static int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] randomNumbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = random.Next(1000, 10000);
        }
        return randomNumbers;
    }

    public static double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        double average = sum / numbers.Length;
        return new double[] { average, min, max };
    }

    public static void Main(string[] args)
    {
        int[] randomNumbers = Generate4DigitRandomArray(5);

        Console.WriteLine("Generated random numbers:");
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            Console.WriteLine(randomNumbers[i]);
        }

        double[] results = FindAverageMinMax(randomNumbers);
        Console.WriteLine("Average: " + results[0]);
        Console.WriteLine("Minimum: " + results[1]);
        Console.WriteLine("Maximum: " + results[2]);
    }
}
