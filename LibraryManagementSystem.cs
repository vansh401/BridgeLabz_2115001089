using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int BookId { get; set; }
    public bool IsAvailable { get; set; }
    public Book Next { get; set; }
    public Book Prev { get; set; }

    public Book(string title, string author, string genre, int bookId, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookId = bookId;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }

    public override string ToString()
    {
        return "Book ID: " + BookId + ", Title: " + Title + ", Author: " + Author + ", Genre: " + Genre + ", Available: " + IsAvailable;
    }
}

class DoublyLinkedList
{
    private Book head;
    private Book tail;

    public DoublyLinkedList()
    {
        head = null;
        tail = null;
    }

    public void AddAtBeginning(Book newBook)
    {
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
    }

    public void AddAtEnd(Book newBook)
    {
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
    }

    public void AddAtPosition(Book newBook, int position)
    {
        if (position == 1)
        {
            AddAtBeginning(newBook);
            return;
        }
        Book current = head;
        int count = 1;
        while (current != null && count < position - 1)
        {
            current = current.Next;
            count++;
        }
        if (current == null)
        {
            Console.WriteLine("Position out of range.");
            return;
        }
        newBook.Next = current.Next;
        newBook.Prev = current;
        if (current.Next != null)
        {
            current.Next.Prev = newBook;
        }
        current.Next = newBook;
    }

    public void RemoveByBookId(int bookId)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }
        Book current = head;
        while (current != null)
        {
            if (current.BookId == bookId)
            {
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                else
                {
                    head = current.Next;
                }
                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    tail = current.Prev;
                }
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void SearchByTitleOrAuthor(string searchTerm)
    {
        Book current = head;
        bool found = false;
        while (current != null)
        {
            if (current.Title.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                current.Author.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(current);
                found = true;
            }
            current = current.Next;
        }
        if (!found)
        {
            Console.WriteLine("No books found with the specified title or author.");
        }
    }

    public void UpdateAvailability(int bookId, bool isAvailable)
    {
        Book current = head;
        while (current != null)
        {
            if (current.BookId == bookId)
            {
                current.IsAvailable = isAvailable;
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void DisplayAllForward()
    {
        Book current = head;
        while (current != null)
        {
            Console.WriteLine(current);
            current = current.Next;
        }
    }

    public void DisplayAllReverse()
    {
        Book current = tail;
        while (current != null)
        {
            Console.WriteLine(current);
            current = current.Prev;
        }
    }

    public int CountTotalBooks()
    {
        int count = 0;
        Book current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }
}

class LibraryManagementSystem
{
    static void Main()
    {
        DoublyLinkedList library = new DoublyLinkedList();
        library.AddAtEnd(new Book("1984", "George Orwell", "Dystopian", 101, true));
        library.AddAtEnd(new Book("To Kill a Mockingbird", "Harper Lee", "Fiction", 102, true));
        library.AddAtEnd(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Classic", 103, false));
        Console.WriteLine("All Books (Forward):");
        library.DisplayAllForward();
        Console.WriteLine();
        Console.WriteLine("All Books (Reverse):");
        library.DisplayAllReverse();
        Console.WriteLine();
        Console.WriteLine("Total number of books:");
        Console.WriteLine(library.CountTotalBooks());
        Console.WriteLine();
        Console.WriteLine("Search for books by Title '1984' or Author 'Harper Lee':");
        library.SearchByTitleOrAuthor("1984");
        library.SearchByTitleOrAuthor("Harper Lee");
        Console.WriteLine();
        Console.WriteLine("Updating availability status for Book ID 102:");
        library.UpdateAvailability(102, false);
        library.DisplayAllForward();
        Console.WriteLine();
        Console.WriteLine("Deleting book with Book ID 101:");
        library.RemoveByBookId(101);
        library.DisplayAllForward();
        Console.WriteLine();
        Console.WriteLine("Adding a book at the beginning:");
        library.AddAtBeginning(new Book("Moby Dick", "Herman Melville", "Adventure", 104, true));
        library.DisplayAllForward();
        Console.WriteLine();
    }
}