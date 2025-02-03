using System;

class Book{
    public string title;
    public string author;
    public double price;
    public bool isAvailable;

    public Book(string title, string author, double price, bool isAvailable){
        this.title = title;
        this.author = author;
        this.price = price;
        this.isAvailable = isAvailable;
    }

    public void BorrowBook(){
        if (isAvailable){
            Console.WriteLine("You have successfully borrowed: " + title);
            isAvailable = false;
        } else {
            Console.WriteLine("Sorry, the book '" + title + "' is currently unavailable.");
        }
    }

    public void DisplayDetails(){
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: $" + price);
        Console.WriteLine("Availability: " + (isAvailable ? "Available" : "Not Available"));
    }
}

class LibrarySystem{
    public static void Main(string[] args){
        Book book1 = new Book("The Alchemist", "Paulo Coelho", 15.99, true);
        Book book2 = new Book("1984", "George Orwell", 12.50, false);

        Console.WriteLine("Book Details Before Borrowing:\n");
        book1.DisplayDetails();
        Console.WriteLine();
        book2.DisplayDetails();

        Console.WriteLine("\nAttempting to Borrow Books:\n");
        book1.BorrowBook();
        book2.BorrowBook();

        Console.WriteLine("\nBook Details After Borrowing:\n");
        book1.DisplayDetails();
        Console.WriteLine();
        book2.DisplayDetails();
    }
}
