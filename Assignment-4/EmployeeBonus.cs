using System;

class EmployeeBonus
{
    static void Main(string[] args)
    {
        Console.Write("Enter the salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter the years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());
        if (yearsOfService > 5)
        {
            double bonus = salary * 0.05; 
            Console.WriteLine("The bonus amount is: " + bonus);
        }
        else
        {
            Console.WriteLine("The employee is not eligible for a bonus.");
        }
    }
}
