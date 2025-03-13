using System;
using System.Collections.Generic;

abstract class Employee
{
    private int employeeId;
    private string name;
    private double baseSalary;
    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }
    protected Employee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }
    public abstract double CalculateSalary();

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Base Salary: $" + baseSalary);
    }
}
class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int employeeId, string name, double baseSalary)
        : base(employeeId, name, baseSalary) { }

    public override double CalculateSalary()
    {
        return BaseSalary; // Fixed salary for full-time employees
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Position: Full-Time Employee");
    }
}

class PartTimeEmployee : Employee
{
    private int workHours;

    public int WorkHours
    {
        get { return workHours; }
        set { workHours = value; }
    }

    public PartTimeEmployee(int employeeId, string name, double baseSalary, int workHours)
        : base(employeeId, name, baseSalary)
    {
        this.workHours = workHours;
    }

    public override double CalculateSalary()
    {
        return BaseSalary * workHours; // Salary based on work hours for part-time employees
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Position: Part-Time Employee");
        Console.WriteLine("Work Hours: " + workHours);
    }
}

interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

class Department : IDepartment
{
    private string departmentName;

    public void AssignDepartment(string department)
    {
        departmentName = department;
    }

    public string GetDepartmentDetails()
    {
        return "Department: " + departmentName;
    }
}

class EmployeeManagementSystem
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee(1, "Vansh Verma", 50000),
            new PartTimeEmployee(2, "Yash", 52, 450)
        };

        Department department = new Department();
        department.AssignDepartment("Sales");

        foreach (Employee employee in employees)
        {
            employee.DisplayDetails();
            Console.WriteLine("Salary: " + employee.CalculateSalary());
            Console.WriteLine(department.GetDepartmentDetails());
            Console.WriteLine();
        }
    }
}
