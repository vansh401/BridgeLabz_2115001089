using System;

class ZaraEmployeeBonus
{
    static void Main()
    {
        const int employeeCount = 10;
        double[] salaries = new double[employeeCount];
        double[] yearsOfService = new double[employeeCount];
        double[] bonuses = new double[employeeCount];
        double[] newSalaries = new double[employeeCount];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine("Enter details for Employee " + (i + 1) + ":");
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());
            if (salary <= 0)
            {
                Console.WriteLine("Invalid salary. Please enter a positive number.");
                i--;
                continue;
            }

            Console.Write("Enter years of service: ");
            double years = double.Parse(Console.ReadLine());
            if (years < 0)
            {
                Console.WriteLine("Invalid years of service. Please enter a non-negative number.");
                i--;
                continue;
            }

            salaries[i] = salary;
            yearsOfService[i] = years;
        }

        for (int i = 0; i < employeeCount; i++)
        {
            double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusPercentage;
            newSalaries[i] = salaries[i] + bonuses[i];
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        Console.WriteLine("Employee Bonus Details:");
        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine("Employee " + (i + 1) + ": Old Salary = " + salaries[i] + ", Bonus = " + bonuses[i] + ", New Salary = " + newSalaries[i]);
        }

        Console.WriteLine("Total Bonus Payout: " + totalBonus);
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}
