using System;
using System.Collections.Generic;

class Employee
{
    public string Name;
    public string Position;

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Position: " + Position);
    }
}

class Department
{
    public string DepartmentName;
    private List<Employee> Employees = new List<Employee>();

    public Department(string departmentName)
    {
        DepartmentName = departmentName;
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Department Name: " + DepartmentName);
        Console.WriteLine("Employees:");
        foreach (var employee in Employees)
        {
            employee.DisplayDetails();
        }
    }
}

class Company
{
    public string CompanyName;
    private List<Department> Departments = new List<Department>();

    public Company(string companyName)
    {
        CompanyName = companyName;
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Company Name: " + CompanyName);
        Console.WriteLine("Departments:");
        foreach (var department in Departments)
        {
            department.DisplayDetails();
        }
    }
}

class CompanyManagementSystem
{
    static void Main()
    {
        Company company = new Company("Vansh Ent.");
        Department dept1 = new Department("Research and Development");
        Department dept2 = new Department("Sales and Marketing");
        Employee emp1 = new Employee("Vansh Verma", "Engineer");
        Employee emp2 = new Employee("yash", "developer");
        dept1.AddEmployee(emp1);
        dept2.AddEmployee(emp2);
        company.AddDepartment(dept1);
        company.AddDepartment(dept2);
        company.DisplayDetails();
    }
}
