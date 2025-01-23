using System;

class FeesDiscount
{
    static void Main()
    {
        Console.Write("Enter the fee: ");
        double fee = double.Parse(Console.ReadLine());

        Console.Write("Enter the discount percentage: ");
        double discountPercent = double.Parse(Console.ReadLine());

        double discount = (fee * discountPercent) / 100;
        double discountedFee = fee - discount;

        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + discountedFee);
    }
}
