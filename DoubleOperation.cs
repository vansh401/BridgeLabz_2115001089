using System;

class DoubleOperation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double result1 = a + b * c; 
        double result2 = a * b + c; 
        double result3 = c + a / b; 
        double result4 = a % b + c; 

        Console.WriteLine("The results of Double Operations are:");
        Console.WriteLine(a + " + " + b + " * " + c + " = " + result1);
        Console.WriteLine(a + " * " + b + " + " + c + " = " + result2);
        Console.WriteLine(c + " + " + a + " / " + b + " = " + result3);
        Console.WriteLine(a + " % " + b + " + " + c + " = " + result4); 
    }
}
