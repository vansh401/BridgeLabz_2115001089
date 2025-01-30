using System;

class StringComparison
{
    static void CompareStrings(string str1, string str2)
    {
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                Console.WriteLine(str1 + " comes before " + str2 + " in lexicographical order");
                return;
            }
            else if (str1[i] > str2[i])
            {
                Console.WriteLine(str2 + " comes before " + str1 + " in lexicographical order");
                return;
            }
        }

        if (str1.Length < str2.Length)
        {
            Console.WriteLine(str1 + " comes before " + str2 + " in lexicographical order");
        }
        else if (str1.Length > str2.Length)
        {
            Console.WriteLine(str2 + " comes before " + str1 + " in lexicographical order");
        }
        else
        {
            Console.WriteLine("Both strings are equal in lexicographical order");
        }
    }

    static void Main()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        CompareStrings(str1, str2);
    }
}
