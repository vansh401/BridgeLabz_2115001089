using System;

class MostFrequentCharacter
{
    static char FindMostFrequentCharacter(string input)
    {
        char mostFrequent = ' ';
        int maxCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            int count = 0;

            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] == currentChar)
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = currentChar;
            }
        }

        return mostFrequent;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char result = FindMostFrequentCharacter(input);
        Console.WriteLine("The most frequent character is: " + result);
    }
}
