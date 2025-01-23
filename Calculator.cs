using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = double.Parse(Console.ReadLine());

        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;

        Console.WriteLine("The addition, subtraction, multiplication, and division of numbers " 
                          + number1 + " and " + number2 + " are " 
                          + addition + ", " + subtraction + ", " + multiplication + ", and " + division);
    }
}
