using System;  

class Book  
{  
    public static string LibraryName { get; set; }    
    public readonly string ISBN;  
    public string Title { get; set; }  
    private string Author { get; set; }  

    public Book(string title, string author, string isbn)  
    {  
        this.Title = title;  
        this.Author = author;  
        this.ISBN = isbn;  
    }  

    public static void DisplayLibraryName()  
    {  
        Console.WriteLine("The name of library is : " + LibraryName);  
    }  

    public void SetAuthor(string author)  
    {  
        this.Author = author;  
    }  

    public string GetAuthor()  
    {  
        return this.Author;  
    }  

    public void DisplayDetails()  
    {  
        if (this is Book)  
        {  
            Console.WriteLine("Book Details:");  
            Console.WriteLine("Library Name: " + LibraryName);  
            Console.WriteLine("Title: " + Title);  
            Console.WriteLine("Author: " + Author);  
            Console.WriteLine("ISBN Number: " + ISBN);  
        }  
        else  
        {  
            Console.WriteLine("The object is not a valid object");  
        }  
    }  
}  

class LibraryManagementSystem  
{  
    static void Main()  
    {  
        Book.LibraryName = "GLA Library";  
        Book book1 = new Book("Wuthering Heights", "Emily Bronte", "546-4378-866-211");  
        Book book2 = new Book("Short Stories", "Leo Tolstoy", "123-123-123-123");  
        
        book1.DisplayDetails();  
        book2.DisplayDetails();  
    }  
}  
