using System;

class Student{
	public static int AddNum(int a,int b){
		return a+b;
	}
}

class Program2 {
	public static void Main(string[] args){
		int sum=Student.AddNum(7,8);     // here we do not create a object of Student class, we can access static method directly with classname.
		Console.WriteLine(sum);
	}
}