using System;

class DuplicateStringRemove
{
    static string RemoveDuplicates(string s)
    {
        string result = ""; 

        for (int i = 0; i < s.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < result.Length; j++)
            {
                if (s[i] == result[j])
                {
                    isDuplicate = true;
                    break; 
                }
            }
            if (!isDuplicate)
            {
                result += s[i];
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string newString = RemoveDuplicates(input);
        Console.WriteLine("String after removing duplicates: " + newString);
    }
}
