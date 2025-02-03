using System;

class Book{
    public string title;
    public string author;
    public double price;

    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void DisplayDetails(){
        Console.WriteLine("Book title: " + title);
        Console.WriteLine("Book author: " + author);
        Console.WriteLine("Book price: " + price);
    }
}

class BookDetails{
    public static void Main(string[] args){
        Console.WriteLine("Enter the book title:");
        string title = Console.ReadLine();
        
        Console.WriteLine("Enter the book author:");
        string author = Console.ReadLine();
        
        Console.WriteLine("Enter the book price:");
        double price = Convert.ToDouble(Console.ReadLine());

        Book book1 = new Book(title, author, price);
        book1.DisplayDetails();
    }
}
