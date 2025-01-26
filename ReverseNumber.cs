using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int tempNumber = number;
        int count = 0;

        while (tempNumber != 0)
        {
            count++;
            tempNumber /= 10;
        }

        int[] digits = new int[count];
        int index = 0;

        while (number != 0)
        {
            digits[index] = number % 10;
            number /= 10;
            index++;
        }

        Console.Write("Reversed number: ");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i]);
        }

    }
}
