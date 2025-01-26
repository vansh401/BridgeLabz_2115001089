using System;

class BMICalculatorArray
{
    static void Main()
    {
        Console.WriteLine("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        double[] weight = new double[numberOfPersons];
        double[] height = new double[numberOfPersons];
        double[] bmi = new double[numberOfPersons];
        string[] status = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("Enter weight (in kg) for person " + (i + 1) + ": ");
            weight[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height (in cm) for person " + (i + 1) + ": ");
            double heightCm = double.Parse(Console.ReadLine());
            height[i] = heightCm / 100;  

            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] <= 18.4)
            {
                status[i] = "Underweight";
            }
            else if (bmi[i] >= 18.5 && bmi[i] <= 24.9)
            {
                status[i] = "Normal";
            }
            else if (bmi[i] >= 25.0 && bmi[i] <= 39.9)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obese";
            }
        }

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ": Weight = " + weight[i] + " kg, Height = " + height[i] * 100 + " cm, BMI = " + bmi[i] + ", Status = " + status[i]);
        }
    }
}
