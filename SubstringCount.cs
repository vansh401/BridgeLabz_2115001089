using System;

class SubstringCount
{
    static int CountSubstring(string mainString, string subString)
    {
        int count = 0;

        for (int index = 0; index <= mainString.Length - subString.Length; index++)
        {
            bool isMatch = true;
            for (int j = 0; j < subString.Length; j++)
            {
                if (mainString[index + j] != subString[j])
                {
                    isMatch = false;
                    break;
                }
            }

            if (isMatch)
            {
                count++;
                index += subString.Length - 1; 
            }
        }

        return count;
    }

    static void Main()
    {
        Console.Write("Enter the main string: ");
        string mainString = Console.ReadLine();

        Console.Write("Enter the substring: ");
        string subString = Console.ReadLine();

        int n = CountSubstring(mainString, subString);
        Console.WriteLine("The substring '" + subString + "' occurs : " + n + " times");
    }
}
