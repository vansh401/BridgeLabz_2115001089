using System;

public class BMICalculator
{
    public static void CalculateBMI(double[,] persons)
    {
        for (int i = 0; i < 10; i++)
        {
            double weight = persons[i, 0];
            double heightInCm = persons[i, 1];
            double heightInMeters = heightInCm / 100;

            
            double bmi = weight / (heightInMeters * heightInMeters);
            persons[i, 2] = bmi;
        }
    }

    public static string[] DetermineBMIStatus(double[,] persons)
    {
        string[] bmiStatus = new string[10];

        for (int i = 0; i < 10; i++)
        {
            double bmi = persons[i, 2];

            if (bmi <= 18.4)
            {
                bmiStatus[i] = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                bmiStatus[i] = "Normal";
            }
            else if (bmi >= 25.0 && bmi <= 39.9)
            {
                bmiStatus[i] = "Overweight";
            }
            else
            {
                bmiStatus[i] = "Obese";
            }
        }

        return bmiStatus;
    }

    public static void Main(string[] args)
    {
        double[,] persons = new double[10, 3]; // 10 persons, 3 columns (Weight, Height, BMI)

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter details for person " + (i + 1) + ":");

            Console.Write("Enter weight in kg: ");
            persons[i, 0] = double.Parse(Console.ReadLine());

            Console.Write("Enter height in cm: ");
            persons[i, 1] = double.Parse(Console.ReadLine());
        }

        CalculateBMI(persons);
        string[] bmiStatus = DetermineBMIStatus(persons);

        Console.WriteLine("\nPerson Details:");
        for (int i = 0; i < 10; i++)
        {
            double weight = persons[i, 0];
            double height = persons[i, 1];
            double bmi = persons[i, 2];
            string status = bmiStatus[i];

            Console.WriteLine("Person " + (i + 1) + " -> Weight: " + weight + " kg, Height: " + height + " cm, BMI: " + bmi.ToString("F2") + ", Status: " + status);
        }
    }
}
