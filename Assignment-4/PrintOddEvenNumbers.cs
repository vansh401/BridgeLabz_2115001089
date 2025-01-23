using System;

class PrintOddEvenNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("Odd and even numbers between 1 and " + number + ":");
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is an even number");
                }
                else
                {
                    Console.WriteLine(i + " is an odd number");
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a natural number greater than 0.");
        }
    }
}
