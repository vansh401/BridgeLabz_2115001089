using System;

class Student {
	public static int TotalStudents=0;  //this is a static variable
	public string Name;
	
	public Student(string name){
		Name=name;
		TotalStudents++;
	}
}

class Program1{
	static void Main(string[] args){
		Student s1=new Student("vansh"); 
		Student s2=new Student("yash");
		
		Console.WriteLine(Student.TotalStudents);
	}
}