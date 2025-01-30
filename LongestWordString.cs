using System;

class LongestWordString
{
    static string FindLongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        return longestWord;
    }

    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string inputSentence = Console.ReadLine();
        string longestWord = FindLongestWord(inputSentence);
        Console.WriteLine("longest word in  sentence is: " + longestWord);
    }
}
