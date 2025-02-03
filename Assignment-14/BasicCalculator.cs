using System;

class BasicCalculator
{
    public static void Main()
    {
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice (1/2/3/4): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result: " + Add(num1, num2));
                break;
            case 2:
                Console.WriteLine("Result: " + Subtract(num1, num2));
                break;
            case 3:
                Console.WriteLine("Result: " + Multiply(num1, num2));
                break;
            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine("Result: " + Divide(num1, num2));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        return a / b;
    }
}
