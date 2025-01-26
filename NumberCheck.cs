using System;

class NumberCheck
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                Console.WriteLine("Number " + numbers[i] + " is positive and " + (numbers[i] % 2 == 0 ? "even." : "odd."));
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine("Number " + numbers[i] + " is negative.");
            }
            else
            {
                Console.WriteLine("Number " + numbers[i] + " is zero.");
            }
        }

        if (numbers[0] == numbers[numbers.Length - 1])
        {
            Console.WriteLine("The first and last elements are equal.");
        }
        else if (numbers[0] > numbers[numbers.Length - 1])
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else
        {
            Console.WriteLine("The first element is less than the last element.");
        }
    }
}
