using System;

class Book{
    public string title;
    public string author;
    public double price;

    public Book(){
        title = "Default title";
        author = "vansh";
        price = 0.0;
    }

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
        Book book1 = new Book();
        Book book2 = new Book("wuthering heights", "emily bronte", 500);
        
        Console.WriteLine("Default Book:");
        book1.DisplayDetails();
        
        Console.WriteLine("Parameterized Book:");
        book2.DisplayDetails();
    }
}
