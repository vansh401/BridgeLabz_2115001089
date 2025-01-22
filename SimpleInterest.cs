using System;

class SimpleInterest
{
    static void Main(string[] args)
    {
        Console.Write("Enter Principal: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time(years): ");
        double time = double.Parse(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("Simple Interest is: " + simpleInterest);
    }
}
