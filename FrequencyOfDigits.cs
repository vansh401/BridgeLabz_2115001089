using System;

class FrequencyOfDigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int tempNumber = number;
        int[] digitsArray = new int[10];
        int index = 0;

        while (tempNumber > 0)
        {
            digitsArray[index++] = tempNumber % 10;
            tempNumber /= 10;
        }

        int[] frequency = new int[10];

        for (int i = 0; i < index; i++)
        {
            frequency[digitsArray[i]]++;
        }

        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + ": " + frequency[i] + " times");
            }
        }
    }
}
