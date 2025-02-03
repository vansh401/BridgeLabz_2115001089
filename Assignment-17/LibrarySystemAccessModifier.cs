using System;

class Book {
    public string ISBN;
    protected string title;
    private string author;

    public Book(string ISBN, string title, string author) {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    public void SetAuthor(string author) {
        this.author = author;
    }

    public string GetAuthor() {
        return author;
    }

    public void DisplayBookDetails() {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
}

class EBook : Book {
    public string fileFormat;

    public EBook(string ISBN, string title, string author, string fileFormat)
        : base(ISBN, title, author) {
        this.fileFormat = fileFormat;
    }

    public void DisplayEBookDetails() {
        Console.WriteLine("EBook ISBN: " + ISBN);
        Console.WriteLine("EBook Title: " + title);
        Console.WriteLine("File Format: " + fileFormat);
    }
}

class LibrarySystemAccessModifier {
    public static void Main(string[] args) {
        Book book1 = new Book("123-456-789", "C# Programming", "vansh verma");
        book1.DisplayBookDetails();
        
        EBook ebook1 = new EBook("987-654-321", "dot net", "yash", "PDF");
        ebook1.DisplayEBookDetails();
    }
}
