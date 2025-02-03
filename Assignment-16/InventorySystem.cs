using System;

class Product {
    public string productName;
    public double price;
    public static int totalProducts = 0;  

    public Product(string productName, double price) {
        this.productName = productName;
        this.price = price;
        totalProducts++;  
    }

    public void DisplayProductDetails() {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: " + price);
    }

    public static void DisplayTotalProducts() {
        Console.WriteLine("Total Products Created: " + totalProducts);
    }
}

class InventorySystem {
    public static void Main(string[] args) {
        Product product1 = new Product("mobile", 22000);
        Product product2 = new Product("bag", 1200);

        Console.WriteLine("Product 1 Details:");
        product1.DisplayProductDetails();
        

        Console.WriteLine("Product 2 Details:");
        product2.DisplayProductDetails();
        

        

        Product.DisplayTotalProducts();
    }
}
