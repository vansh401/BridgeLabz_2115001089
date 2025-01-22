using System;

class CylinderVolume{
	static void Main(string[] args){
		Console.Write("Enter Radius:");
		double radius = double.Parse(Console.ReadLine());
		
		Console.Write("Enter Height:");
		double height = double.Parse(Console.ReadLine());
		
		double volume=Math.PI * Math.Pow(radius,2)* height;
		
		Console.WriteLine("Volume of Cylinder is: " + volume);
	}
}