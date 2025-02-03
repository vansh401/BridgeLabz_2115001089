using System;

class MaxOfThreeNum{
	public static void Main(string[] args){
		int n1=getInput("Enter num1: ");
		int n2=getInput("Enter num2: ");
		int n3=getInput("Enter num3: ");
		int max=findMax(n1,n2,n3);
		
		Console.WriteLine("Max among three is: "+max);
	}
	
	public static int getInput(string msg){
		Console.WriteLine(msg);
		int num=int.Parse(Console.ReadLine());
		return num;
	}
	public static int findMax(int n1,int n2,int n3){
		int max=n1;
		if(n2>max) max=n2;
		if(n3>max) max=n3;
		
		return max;
	}
}