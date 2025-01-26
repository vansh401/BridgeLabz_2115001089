using System;

class BMICalculatorUsing2DArray
{
    static void Main()
    {
        Console.WriteLine("Enter the number of persons: ");
        int numberOfPersons = int.Parse(Console.ReadLine());

        double[,] personData = new double[numberOfPersons, 3];
        string[] weightStatus = new string[numberOfPersons];

        for (int i = 0; i < numberOfPersons; i++)
        {
            double weight;
            do
            {
                Console.WriteLine("Enter weight (in kg) for person " + (i + 1) + ": ");
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive value for weight.");
                }
            } while (weight <= 0);
            personData[i, 0] = weight;

            double heightCm;
            do
            {
                Console.WriteLine("Enter height (in cm) for person " + (i + 1) + ": ");
                heightCm = double.Parse(Console.ReadLine());
                if (heightCm <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive value for height.");
                }
            } while (heightCm <= 0);

            double heightM = heightCm / 100;
            personData[i, 1] = heightM;

            double bmi = weight / (heightM * heightM);
            personData[i, 2] = bmi;

            if (bmi <= 18.4)
            {
                weightStatus[i] = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                weightStatus[i] = "Normal";
            }
            else if (bmi >= 25.0 && bmi <= 39.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }

        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ": Weight = " + personData[i, 0] + " kg, Height = " + personData[i, 1] * 100 + " cm, BMI = " + personData[i, 2] + ", Status = " + weightStatus[i]);
        }
    }
}
