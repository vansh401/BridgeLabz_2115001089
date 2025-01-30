using System;

public class UnitConverter
{
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        double poundsToKilograms = 0.453592;
        return pounds * poundsToKilograms;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilogramsToPounds = 2.20462;
        return kilograms * kilogramsToPounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallonsToLiters = 3.78541;
        return gallons * gallonsToLiters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double litersToGallons = 0.264172;
        return liters * litersToGallons;
    }
}

class UnitConverterCelsiusToFahreneit
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());
        Console.WriteLine(fahrenheit + "°F is " + UnitConverter.ConvertFahrenheitToCelsius(fahrenheit) + "°C.");

        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        Console.WriteLine(celsius + "°C is " + UnitConverter.ConvertCelsiusToFahrenheit(celsius) + "°F.");

        Console.Write("Enter weight in pounds: ");
        double pounds = double.Parse(Console.ReadLine());
        Console.WriteLine(pounds + " pounds is " + UnitConverter.ConvertPoundsToKilograms(pounds) + " kilograms.");

        Console.Write("Enter weight in kilograms: ");
        double kilograms = double.Parse(Console.ReadLine());
        Console.WriteLine(kilograms + " kilograms is " + UnitConverter.ConvertKilogramsToPounds(kilograms) + " pounds.");

        Console.Write("Enter volume in gallons: ");
        double gallons = double.Parse(Console.ReadLine());
        Console.WriteLine(gallons + " gallons is " + UnitConverter.ConvertGallonsToLiters(gallons) + " liters.");

        Console.Write("Enter volume in liters: ");
        double liters = double.Parse(Console.ReadLine());
        Console.WriteLine(liters + " liters is " + UnitConverter.ConvertLitersToGallons(liters) + " gallons.");
    }
}
