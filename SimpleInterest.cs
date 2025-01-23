using System;

class SimpleInterest
{
    static void Main()
    {
        Console.Write("Enter the Principal: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter the Rate: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter the Time(yrs): ");
        double time = double.Parse(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
    }
}
