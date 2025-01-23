using System;

class AthleteRounds
{
    static void Main()
    {
        Console.Write("Enter the length of side1 (in meters): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of side2 (in meters): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of side3 (in meters): ");
        double side3 = double.Parse(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double totalDistance = 5000; //  bcz he want to complete 5 kilometres
        double rounds = totalDistance / perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is " + rounds);
    }
}
