using System;

class HeightConverter
{
    static void Main()
    {
        Console.Write("Enter your height in centimeters: ");
        double heightCm = double.Parse(Console.ReadLine());

        double heightInches = heightCm / 2.54;
        double feet = (heightInches / 12);
        Console.WriteLine("Your Height in cm is " + heightCm + " while in feet is " + feet + " and inches is " + heightInches);
    }
}
