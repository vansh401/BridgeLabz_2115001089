using System;

class IntOperation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        int result1 = a + b * c; 
        int result2 = a * b + c; 
        int result3 = c + a / b; 
        int result4 = a % b + c; 

        Console.WriteLine("The results of Int Operations are:");
        Console.WriteLine(a + " + " + b + " * " + c + " = " + result1);
        Console.WriteLine(a + " * " + b + " + " + c + " = " + result2);
        Console.WriteLine(c + " + " + a + " / " + b + " = " + result3);
        Console.WriteLine(a + " % " + b + " + " + c + " = " + result4);
    }
}
