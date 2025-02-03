using System;

class PalindromeChecker
{
    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();

        if (isPalindrome(s))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    public static bool isPalindrome(string str)
    {
        str = str.ToLower();
        int left = 0, right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
