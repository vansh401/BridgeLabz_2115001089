using System;  

class Employee  
{  
    public static string CompanyName { get; set; }  
    private static int totalEmployees = 0;  
    public readonly int EmployeeId;  
    public string Name { get; set; }  
    private string Designation { get; set; }  

    public Employee(int employeeid, string name, string designation)  
    {  
        this.EmployeeId = employeeid;  
        this.Name = name;  
        this.Designation = designation;  
        totalEmployees++;  
    }  

    public static void GetTotalEmployees()  
    {  
        Console.WriteLine("Total Employees: " + totalEmployees);  
    }  

    public static void DisplayCompanyName()  
    {  
        Console.WriteLine("The name of the company is: " + CompanyName);  
    }  

    public void SetDesignation(string designation)  
    {  
        this.Designation = designation;  
    }  

    public string GetDesignation()  
    {  
        return this.Designation;  
    }  

    public void DisplayDetails()  
    {  
        if (this is Employee)  
        {  
            Console.WriteLine("Employee Details:");  
            Console.WriteLine("Company Name: " + CompanyName);  
            Console.WriteLine("Employee Id: " + EmployeeId);  
            Console.WriteLine("Employee Name: " + Name);  
            Console.WriteLine("Designation: " + Designation);  
        }  
        else  
        {  
            Console.WriteLine("Invalid object");  
        }  
    }  
}  

class EmployeeManagementSystem  
{  
    static void Main()  
    {  
        Employee.CompanyName = "Capgemini";  
        Employee.DisplayCompanyName();  

        Employee employee1 = new Employee(1089, "Vansh Verma", "Web Developer");  
        employee1.DisplayDetails();  

        Employee.GetTotalEmployees();  
    }  
}  
