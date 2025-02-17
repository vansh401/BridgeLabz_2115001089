using System;

class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Book Details:");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }

    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Bio: " + Bio);
    }
}

class LibraryManagementSystem
{
    static void Main()
    {
        Author author = new Author("War and Peace", 1869, "Leo Tolstoy", 
            "Leo Tolstoy was a Russian novelist known for 'War and Peace' and 'Anna Karenina'.");
        
        author.DisplayInfo();
    }
}
