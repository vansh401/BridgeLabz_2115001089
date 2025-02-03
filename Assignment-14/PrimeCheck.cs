using System;

class PrimeCheck
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (isPrime(n))
        {
            Console.WriteLine(n + " is a prime number");
        }
        else
        {
            Console.WriteLine(n + " is not a prime number");
        }
    }

    public static bool isPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= number/2; i++)
        {
            if (number % i == 0)
            {
                return false; 
            }
        }

        return true; 
    }
}
