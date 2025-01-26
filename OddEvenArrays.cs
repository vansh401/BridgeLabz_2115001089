using System;

class OddEvenArrays
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a positive integer.");
            return;
        }

        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
        Console.WriteLine();
    }
}
