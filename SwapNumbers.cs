using System;

class SwapNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        number1 = number1 + number2;
        number2 = number1 - number2;
        number1 = number1 - number2;

        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }
}
