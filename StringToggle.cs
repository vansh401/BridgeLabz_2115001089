using System;

class StringToggle
{
    static string ToggleStringCase(string input)
    {
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 'A' && input[i] <= 'Z')
            {
                result += (char)(input[i] + 32);
            }
            else if (input[i] >= 'a' && input[i] <= 'z')
            {
                result += (char)(input[i] - 32);
            }
            else
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

        string result = ToggleStringCase(input);
        Console.WriteLine("String after toggling case: " + result);
    }
}
