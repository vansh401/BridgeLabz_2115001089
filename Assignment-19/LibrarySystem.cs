using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void DisplayBook()
    {
        Console.WriteLine("The title of the book is " + Title);
        Console.WriteLine("The author of the book is " + Author);
    }
}

class Library
{
    public string LibraryName;
    private List<Book> books = new List<Book>();

    public Library(string libraryName)
    {
        LibraryName = libraryName;
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine(book.Title + " has been added to " + LibraryName + " library!");
    }

    public void DisplayBooks()
    {
        Console.WriteLine("The books in the " + LibraryName + " Library are:");
        for (int i = 0; i < books.Count; i++)
        {
            books[i].DisplayBook();
        }
    }
}

class LibrarySystem
{
    public static void Main(string[] args)
    {
        Library library1 = new Library("Gla");
        Library library2 = new Library("vansh");

        Book book1 = new Book("wuthering heights", "emily bronte");
        Book book2 = new Book("death in kasol", "Gunjesh Bond");
     
        library1.AddBook(book1);
        library2.AddBook(book2);

        library1.DisplayBooks();
        library2.DisplayBooks();
    }
}
