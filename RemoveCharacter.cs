using System;

class RemoveCharacter
{
    static string RemoveCharacterFromString(string input, char charToRemove)
    {
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != charToRemove)
            {
                result += input[i];
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadLine()[0];

        string modifiedString = RemoveCharacterFromString(input, charToRemove);
        Console.WriteLine("Modified String: " + modifiedString);
    }
}
