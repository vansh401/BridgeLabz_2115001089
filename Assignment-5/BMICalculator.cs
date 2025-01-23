using System;

class BMICalculator
{
    static void Main()
    {
        Console.Write("Enter weight (in kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height (in cm): ");
        double heightCm = double.Parse(Console.ReadLine());

        double heightM = heightCm / 100;

        double bmi = weight / (heightM * heightM);

        Console.WriteLine("Your BMI is: " + bmi);

        if (bmi <= 18.4)
        {
            Console.WriteLine("Status: Underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Status: Normal");
        }
        else if (bmi >= 25.0 && bmi <= 39.9)
        {
            Console.WriteLine("Status: Overweight");
        }
        else
        {
            Console.WriteLine("Status: Obese");
        }
    }
}
