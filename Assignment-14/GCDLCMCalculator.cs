using System;

class GCDLCMCalculator
{
    public static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2, gcd);

        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }

    public static int CalculateGCD(int a, int b)
	{
		if (b == 0)
			return a;
    return CalculateGCD(b, a % b);
}

    public static int CalculateLCM(int a, int b, int gcd)
    {
        return (a / gcd) * b;
    }
}
