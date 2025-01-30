using System;

class PalindromeString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        string reverseString = "";
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverseString += input[i];
        }

        if (input == reverseString)
        {
            Console.WriteLine("string is a palindrome.");
        }
        else
        {
            Console.WriteLine("string is not a palindrome.");
        }
    }
}
