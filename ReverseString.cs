using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        string reversed = "";
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i]; 
        }

        Console.WriteLine("Reversed string: " + reversed);
    }
}
