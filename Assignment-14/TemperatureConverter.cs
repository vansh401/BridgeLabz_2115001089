using System;

class TemperatureConverter
{
    public static void Main()
    {
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(temp));
                break;
            case 2:
                Console.WriteLine("Celsius: " + FahrenheitToCelsius(temp));
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    public static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    public static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}
