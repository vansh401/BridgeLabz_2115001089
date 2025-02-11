using System;  

class Product  
{  
    public static double Discount { get; set; }
    public readonly string ProductID;  
    public string ProductName { get; set; }  
    public double Price { get; set; }  
    public int Quantity { get; set; }  
	
	static Product()
    {
        Discount = 0.0;
    }

    public Product(string productName, double price, int quantity, string productID)  
    {  
        this.ProductName = productName;  
        this.Price = price;  
        this.Quantity = quantity;  
        this.ProductID = productID;  
    }  

    public static void UpdateDiscount(double newDiscount)  
    {  
        Discount = newDiscount;  
    }  

    public void DisplayDetails()  
    {  
        if (this is Product)  
        {  
            Console.WriteLine("Product Details:");  
            Console.WriteLine("Product ID: " + ProductID);  
            Console.WriteLine("Product Name: " + ProductName);  
            Console.WriteLine("Price: " + Price);  
            Console.WriteLine("Quantity: " + Quantity);  
            Console.WriteLine("Discount: " + Discount + "%");  
        }  
        else  
        {  
            Console.WriteLine("Invalid object");  
        }  
    }  
}  

class ShoppingCartSystem  
{  
    static void Main()  
    {  
        Product.UpdateDiscount(10.0);  

        Product product1 = new Product("Laptop", 55000, 1, "4344");  
        Product product2 = new Product("Mobile", 24000, 2, "2341");  

        product1.DisplayDetails();  
        product2.DisplayDetails();  
    }  
}  
