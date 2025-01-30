using System;

class Student{
	public static int AddNum(int a,int b){
		return a+b;
	}
}

class Program3 {
	public static void Main(string[] args){
		
		Console.WriteLine("hello");
		display();
	}
	public void display(){                  // here if we do not make this method static it will cause error, bcz static methods can be called in static method only
		int sum=Student.AddNum(6,8);
		Console.WriteLine(sum);
	}
}