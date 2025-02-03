using System;

class Employee {
    public int employeeID;
    protected string department;
    private double salary;

    public Employee(int employeeID, string department, double salary) {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    public void ModifySalary(double newSalary) {
        if (newSalary > 0) {
            salary = newSalary;
        } else {
            Console.WriteLine("Invalid salary value");
        }
    }

    public double GetSalary() {
        return salary;
    }

    public void DisplayEmployeeDetails() {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: " + salary);
    }
}

class Manager : Employee {
    public string designation;

    public Manager(int employeeID, string department, double salary, string designation)
        : base(employeeID, department, salary) {
        this.designation = designation;
    }

    public void DisplayManagerDetails() {
        Console.WriteLine("Designation: " + designation);
    }
}

class EmployeeRecords {
    public static void Main(string[] args) {
        Employee employee1 = new Employee(101, "Sales", 50000);
        employee1.DisplayEmployeeDetails();
        employee1.ModifySalary(55000);
        Console.WriteLine("Updated Salary: " + employee1.GetSalary());

        Manager manager1 = new Manager(102, "HR", 80000, "HR Manager");
        manager1.DisplayEmployeeDetails();
        manager1.DisplayManagerDetails();
    }
}
