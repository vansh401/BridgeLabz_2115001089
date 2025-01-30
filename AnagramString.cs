using System;

class AnagramString
{
    static bool IsAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();
        
        Array.Sort(arr1);
        Array.Sort(arr2);

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        bool result = IsAnagrams(str1, str2);
        if (result)
        {
            Console.WriteLine("The strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The strings are not anagrams.");
        }
    }
}
