using System;

class QuotientRemainder
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());

        int quotient = number1 / number2;
        int remainder = number1 % number2;

        Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2);
    }
}
