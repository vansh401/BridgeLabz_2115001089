using System;

class Employee{
	public string name;
	public int id;
	public int salary;
	
	public Employee(string name, int id, int salary){
		this.name=name;
		this.id=id;
		this.salary=salary;
	}
	
	public void displayResult(){
		Console.WriteLine("Employee name is: "+name);
		Console.WriteLine("Employee id: "+id);
		Console.WriteLine("Employee salary: "+salary);
	}
}

class EmployeeDetails{
	public static void Main(String[] args){
		Employee employee1= new Employee("Vansh Verma",2115001089,25000);
		employee1.displayResult();
	}
}