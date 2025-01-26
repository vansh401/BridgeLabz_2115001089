using System;

class SumOfArray
{
    static void Main()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double input = double.Parse(Console.ReadLine());

            if (input <= 0 || index == 10)
            {
                break;
            }

            numbers[index] = input;
            index++;
        }

        Console.WriteLine("You entered the following numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        Console.WriteLine("The total sum of the numbers is: " + total);
    }
}
