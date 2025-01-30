using System;

class VowelCounter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        int vowels = 0, consonants = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = char.ToLower(input[i]); 

            if (c >= 'a' && c <= 'z')  
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }

        Console.WriteLine("Number of vowels: " + vowels);
        Console.WriteLine("Number of consonants: " + consonants);
    }
}
