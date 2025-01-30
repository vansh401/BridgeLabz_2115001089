using System;

class ReplaceStringWord
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        Console.WriteLine("Enter the word to replace:");
        string wordReplace = Console.ReadLine();
        Console.WriteLine("Enter the new word:");
        string newWord = Console.ReadLine();
        string newSentence = WordReplace(sentence, wordReplace, newWord);
        Console.WriteLine("Modified sentence: " + newSentence);
    }

    static string WordReplace(string sentence, string wordReplace, string newWord)
    {
        string result = "";
        string[] words = SplitIntoWords(sentence);
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == wordReplace)
            {
                result += newWord;
            }
            else
            {
                result += words[i];
            }
            if (i < words.Length - 1)
            {
                result += " ";
            }
        }
        return result;
    }

    static string[] SplitIntoWords(string sentence)
    {
        string[] words = new string[sentence.Length];
        int wIndex = 0;
        string currentWord = "";
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
            {
                if (currentWord != "")
                {
                    words[wIndex++] = currentWord;
                    currentWord = "";
                }
            }
            else
            {
                currentWord += sentence[i];
            }
        }
        if (currentWord != "")
        {
            words[wIndex++] = currentWord;
        }
        string[] result = new string[wIndex];
        for (int i = 0; i < wIndex; i++)
        {
            result[i] = words[i];
        }
        return result;
    }
}
