using System;

class FahrenheitToCelsius
{
    static void Main()
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine(fahrenheit + " Fahrenheit is " + celsius + " Celsius.");
    }
}
