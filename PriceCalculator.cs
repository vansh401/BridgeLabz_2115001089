using System;

class PriceCalculator
{
    static void Main()
    {
        Console.Write("Enter the unit price of the item: ");
        double unitPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter the quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        double totalPrice = unitPrice * quantity;

        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity is " + quantity + " and the unit price is INR " + unitPrice);
    }
}
