using System;
using System.Collections.Generic;

interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

abstract class Product
{
    private int productId;
    private string name;
    private double price;
    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    protected Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }
    public abstract double CalculateDiscount();
    public virtual void GetProductDetails()
    {
        Console.WriteLine("Product ID: " + productId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Price: " + price);
    }
}

class Electronics : Product, ITaxable
{
    public Electronics(int productId, string name, double price)
        : base(productId, name, price) { }
    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }
    public double CalculateTax()
    {
        return Price * 0.15;
    }
    public string GetTaxDetails()
    {
        return "Tax Rate: 15%";
    }
    public override void GetProductDetails()
    {
        base.GetProductDetails();
        Console.WriteLine("Category: Electronics");
    }
}

class Clothing : Product, ITaxable
{
    public Clothing(int productId, string name, double price)
        : base(productId, name, price) { }
    public override double CalculateDiscount()
    {
        return Price * 0.20;
    }
    public double CalculateTax()
    {
        return Price * 0.08;
    }
    public string GetTaxDetails()
    {
        return "Tax Rate: 8%";
    }
    public override void GetProductDetails()
    {
        base.GetProductDetails();
        Console.WriteLine("Category: Clothing");
    }
}

class Groceries : Product
{
    public Groceries(int productId, string name, double price)
        : base(productId, name, price) { }
    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
    public override void GetProductDetails()
    {
        base.GetProductDetails();
        Console.WriteLine("Category: Groceries");
    }
}

class EcommercePlatform
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics(101, "Laptop", 100000),
            new Clothing(102, "T-Shirt", 5000),
            new Groceries(103, "Apple", 10)
        };

        foreach (Product product in products)
        {
            product.GetProductDetails();
            double tax = 0;
			ITaxable taxableProduct = product as ITaxable;
            if (taxableProduct != null)
            {
                tax = taxableProduct.CalculateTax();
                Console.WriteLine(taxableProduct.GetTaxDetails());
            }
            double discount = product.CalculateDiscount();
            double finalPrice = product.Price + tax - discount;
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Final Price: " + finalPrice);
            Console.WriteLine();
        }
    }
}
