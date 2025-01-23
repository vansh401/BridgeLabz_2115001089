using System;

class SmallestNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number1: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the number2: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the number3: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine("Yes, first number is the smallest");
        }
        else
        {
            Console.WriteLine("No, first number is not a smallest");
        }
    }
}
