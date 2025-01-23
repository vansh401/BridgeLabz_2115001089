using System;

class DivisibleBy5{
	static void Main(string[] args){
		Console.WriteLine("Enter a Number: ");
		int num=int.Parse(Console.ReadLine());
		if(num%5==0){
			Console.WriteLine(num+" is divisible by 5");
		}
		else{
			Console.WriteLine(num+" is not divisible by 5");

		}
	}
}